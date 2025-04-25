using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using SDB.Classes.General;

namespace SDB.Classes.Ticket
{
	public class ClassTicket_Image
	{
		public const int MAX_FILE_SIZE_BYTES = 2097152;

		public int ID { get; set; }
		public int TicketID { get; set; }
		public int UserID { get; set; }
		public Image TicketImage { get; set; }
		public string Description { get; set; }
		public DateTime ImageDate { get; set; }

		/// <summary>
		/// Gets all images for the specified ticket.
		/// </summary>
		public static IEnumerable<ClassTicket_Image> GetByTicket(int ticketID)
		{
			var ticketImages = new List<ClassTicket_Image>();
			using (var conn = ClassDatabase.CreateMySqlConnection())
			{
				conn.Open();
				using (var cmd = conn.CreateCommand())
				{
					cmd.CommandText =
						@"SELECT ti.id, ti.ticket_id, ti.user_id, ti.imagedata, ti.description, ti.image_dt
						FROM ticket_images ti
						WHERE ti.ticket_id = @TicketID
						ORDER BY ti.image_dt ASC;";
					cmd.Parameters.AddWithValue("TicketID", ticketID);
					using (var reader = cmd.ExecuteReader())
					{
						while (reader.Read())
						{
							var ticketImage = new ClassTicket_Image
							{
								ID = reader.GetDBInt("id"),
								TicketID = reader.GetDBInt("ticket_id"),
								UserID = reader.GetDBInt("user_id"),
								TicketImage = reader.GetDBImage("imagedata"),
								Description = reader.GetDBString("description"),
								ImageDate = reader.GetDBDateTime("image_dt")
							};
							ticketImages.Add(ticketImage);
						}
					}
				}
				conn.Close();
			}
			return ticketImages;
		}

		/// <summary>
		/// Adds a ticket image to the database.
		/// </summary>
		public static void AddImage(int ticketId, Image ticketImage, string imageDescription)
		{
			using (var jpgData = new MemoryStream())
			{
				ticketImage.Save(jpgData, ImageFormat.Jpeg);
				if (jpgData.Length > MAX_FILE_SIZE_BYTES)
					throw new Exception($"File must be less than {MAX_FILE_SIZE_BYTES} bytes.");

				using (var conn = ClassDatabase.CreateMySqlConnection())
				{
					conn.Open();
					using (var cmd = conn.CreateCommand())
					{
						cmd.CommandText =
							@"INSERT INTO ticket_images
							(ticket_id, user_id, imagedata, description, image_dt)
							VALUES
							(@ticketId, @userId, @imageData, @imageDescription, NOW());";
						cmd.Parameters.AddWithValue("ticketId", ticketId);
						cmd.Parameters.AddWithValue("userId", GS.Settings.LoggedOnUser.ID);
						cmd.Parameters.AddWithValue("imageData", jpgData.ToArray());
						cmd.Parameters.AddWithValue("imageDescription", imageDescription);
						cmd.ExecuteNonQuery();
					}
					conn.Close();
				}
			}
		}

		/// <summary>
		/// Deletes this ticket image.
		/// </summary>
		public void Delete()
		{
			using (var conn = ClassDatabase.CreateMySqlConnection())
			{
				conn.Open();
				using (var cmd = conn.CreateCommand())
				{
					cmd.CommandText =
						@"DELETE FROM ticket_images
						WHERE id = @ticketImageID;";
					cmd.Parameters.AddWithValue("ticketImageID", ID);
					cmd.ExecuteNonQuery();
				}
				conn.Close();
			}
		}
	}
}