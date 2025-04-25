using System;
using System.Linq;
using System.Windows.Forms;
using SDB.Classes.RMA;

namespace SDB.Forms.RMA
{
	public partial class FormRMA_MoveStuff : Form
	{
		private string _firstInput;
		private string _secondInput;

		public FormRMA_MoveStuff()
		{
			InitializeComponent();
		}

		private void btnInput_Click(object sender, EventArgs e)
		{
			if (string.IsNullOrEmpty(_firstInput))
			{
				_firstInput = txtInput.Text;
				WriteStatus(_firstInput + " > ", false);
				txtInput.Clear();
				timerInputWaitTimeout.Start();
				return;
			}

			timerInputWaitTimeout.Stop();
			_secondInput = txtInput.Text;
			WriteStatus(_secondInput);
			txtInput.Clear();
			MoveStuff();
			Reset();
		}

		private void timerInputWaitTimeout_Tick(object sender, EventArgs e)
		{
			WriteStatus("TIMED OUT");
			timerInputWaitTimeout.Stop();
			Reset();
		}

		private void Reset()
		{
			_firstInput = _secondInput = string.Empty;
		}

		private void MoveStuff()
		{
			// TODO: Experimental inventory move manager screen - handle first and second inputs.
			// Because assembly serial numbers could have any particular letter as a prefix, determining if something is an assembly, bin or zone is more difficult...
			// The second scan is treated as a bin or zone destination and must match one of their formats

			if (ClassRMA_Bin.ValidateBinName(_secondInput))
				MoveAssemblyToBin();
			else if (ClassRMA_Zone.ValidateZoneName(_secondInput))
				MoveBinToZone();
			else
				WriteStatus("UNRECOGNIZED DESTINATION");
		}

		private void MoveAssemblyToBin()
		{
			WriteStatus($"MOVE ASSEMBLY W/ SN {_firstInput} TO BIN {_secondInput}...");

			// Find assembly serial number among assemblies that are currently in bins.
			var thisAssemblyInstances = ClassRMA.ClassRMAAssembly.GetBySerialNumber(_firstInput);
			if (!thisAssemblyInstances.Any())
			{
				WriteStatus($"\tASSEMBLY SN '{_firstInput}' NOT FOUND");
				return;
			}

			// Find instances where the RMA is open (should only be one)
			var rmas = thisAssemblyInstances.Select(a => ClassRMA.GetRMA(a.RMA_ID)).ToList();
			thisAssemblyInstances = thisAssemblyInstances.Where(a => rmas.Where(r => !r.IsCompleted && !r.IsDeleted).Select(r => r.ID).Contains(a.RMA_ID)).ToList();
			if (thisAssemblyInstances.Count > 1)
			{
				WriteStatus($"\tMULTIPLE INSTANCES OF SN '{_firstInput}' FOUND:");
				foreach (var inst in thisAssemblyInstances)
				{
					var box = ClassRMA_Bin.GetByID(inst.Bin_ID);
					string locationString;
					if (box == null)
						locationString = string.Empty;
					else
					{
						var zone = ClassRMA_Zone.GetByID(box.Zone_ID);
						if (zone == null)
							locationString = $"Bin '{box.BinName}', Not in any zone.";
						else
						{
							var area = ClassRMA_Area.GetByID(zone.Area_ID);
							locationString = $"Bin '{box.BinName}', Zone '{zone.ZoneName}', Area '{area.AreaName}'";
						}
					}
					WriteStatus($"\tIn RMA {inst.RMA_ID} {locationString}");
				}
				return;
			}

			if (thisAssemblyInstances.Count == 0)
			{
				WriteStatus($"\tNO OPEN RMA WITH SN '{_firstInput}'.");
				return;
			}

			// Validate destination bin
			var destinationBin = ClassRMA_Bin.GetByName(_secondInput);
			if (destinationBin == null)
			{
				WriteStatus("\tINVALID BIN");
				return;
			}

			// Only one open RMA found, proceed with move
			var assemblyToMove = thisAssemblyInstances.First();

			// Verify that destination is not the same as the bin assembly is already assigned to
			var existingBin = ClassRMA_Bin.GetBinForAssembly(assemblyToMove.ID);
			if (existingBin != null && existingBin.ID == destinationBin.ID)
			{
				WriteStatus($"\tFAILED: ASSEMBLY SN '{assemblyToMove.SerialNumber}' ALREADY IN BIN '{destinationBin.BinName}'");
				return;
			}
			destinationBin.AssignAssemblyToBin(assemblyToMove);
			WriteStatus($"\tSUCCESS: MOVED ASSEMBLY SN '{assemblyToMove.SerialNumber}' TO BIN '{destinationBin.BinName}'");
		}

		private void MoveBinToZone()
		{
			WriteStatus($"MOVE BIN {_firstInput} TO ZONE {_secondInput}...");
			var bin = ClassRMA_Bin.GetByName(_firstInput);
			if (bin == null)
			{
				WriteStatus("\tINVALID BIN");
				return;
			}

			var destinationZoneID = ClassRMA_Zone.GetIDFromString(_secondInput);
			if (destinationZoneID == 0)
			{
				WriteStatus("\tINVALID ZONE");
				return;
			}
			var destinationZone = ClassRMA_Zone.GetByID(destinationZoneID);
			if (destinationZone == null)
			{
				WriteStatus("\tINVALID ZONE");
				return;
			}

			var existingZone = ClassRMA_Zone.GetByID(bin.Zone_ID);
			if (existingZone != null && existingZone.ID == destinationZone.ID)
			{
				WriteStatus($"\tFAILED: BIN '{bin.BinName}' ALREADY IN ZONE '{destinationZone.ZoneName}'");
				return;
			}
			var area = ClassRMA_Area.GetByID(destinationZone.Area_ID);
			bin.Move(destinationZone.ID);
			WriteStatus($"\tSUCCESS: MOVED BIN '{bin.BinName}' TO ZONE '{destinationZone.ZoneName}' (AREA '{area.AreaName}')");
		}

		private void WriteStatus(string status, bool includeNewLine = true)
		{
			txtStatus.AppendText(includeNewLine ? $"{status}{Environment.NewLine}" : status);
		}

		private void btnClose_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void txtInput_Enter(object sender, EventArgs e)
		{
			AcceptButton = btnInput;
		}
	}
}