//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34209
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using System;
namespace AssemblyCSharp
{
	public class Commander : Role
	{
		public override ViewStyle viewStyle ()
		{
			return ViewStyle.topDown;
		}

		public override bool becomeSoldier()
		{
			bool success = false;
			Console.WriteLine ("Attempting to become a Soldier");
			if (CommandBase.Instance.leave(this)) {
				Console.WriteLine ("You are now soldier!");
				success = true;
			} else {
				Console.WriteLine ("You are still the commander! ");
				// success already false
			}
			return success;
		}
		
		public override bool becomeCommander()
		{
			Console.WriteLine("Already the Commander!");
			return false;

		}

		public bool promptLeave()
		{
			Console.WriteLine ("Being prompted to leave");
			// Currently always give up being a commander
			CommandBase.Instance.leave (this);
			return true;
		}

		public Commander ()
		{
		}
	}
}

