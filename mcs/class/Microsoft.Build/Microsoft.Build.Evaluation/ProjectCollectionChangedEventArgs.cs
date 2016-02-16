using System;
using Microsoft.Build.Construction;

namespace Microsoft.Build.Evaluation
{
	public class ProjectCollectionChangedEventArgs : EventArgs
	{
		public ProjectCollectionChangedEventArgs (ProjectCollectionChangedState state)
		{
			State = state;
		}
		
		public ProjectCollectionChangedState State { get; private set; }

		[MonoTODO]
		public ProjectCollectionChangedState Changed {
			get {
				throw new NotImplementedException ();
			}
			set {
				throw new NotImplementedException ();
			}
		}
	}
}

