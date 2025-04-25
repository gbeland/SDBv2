using System;
using System.Collections;
using System.Collections.Generic;
using System.Windows.Forms;
using BrightIdeasSoftware;

namespace SDB.Classes.General
{
	/// <summary>
	/// Wrapper for ObjectListView sorting (to compare underlying objects)
	/// </summary>
	/// <remarks>See http://stackoverflow.com/a/13291780/161052 </remarks>
	public class ClassObjectListViewModelComparer<T> : IComparer where T : class
	{
		private readonly IComparer<T> _comparer;

		public ClassObjectListViewModelComparer(IComparer<T> comparer)
		{
			_comparer = comparer;
		}

		public int Compare(object x, object y)
		{
			if (x == null && y == null)
				return 0;

			if (x == null || !(x is ListViewItem))
				return -1;

			if (y == null || !(y is ListViewItem))
				return 1;

			ListViewItem item1 = x as ListViewItem;
			ListViewItem item2 = y as ListViewItem;

			if (!(item1.ListView is ObjectListView))
				throw new ArgumentException("Underlying ListView is not of type " + typeof (ObjectListView));

			ObjectListView view = item1.ListView as ObjectListView;

			object obj1 = view.GetModelObject(item1.Index);
			object obj2 = view.GetModelObject(item2.Index);

			if (!(obj1 is T) || !(obj2 is T))
				throw new ArgumentException("ObjectListView data objects are not of specified type " + typeof (T));

			T model1 = obj1 as T;
			T model2 = obj2 as T;

			return _comparer.Compare(model1, model2);
		}
	}
}