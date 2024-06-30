using System.Diagnostics;

namespace _29_Attributes
{
    // The DebuggerDisplay attribute is used to specify a string that is displayed in the debugger.
    // The DebuggerDisplay attribute is used to provide a customized display string for a class or structure.
    // The DebuggerDisplay attribute is defined in the System.Diagnostics namespace.
    [DebuggerDisplay("No = {_no}, Title = {_title}")]
    public class Update
    {
        private int _no;
        private string _title;

        public Update(int no, string title)
        {
            _no = no;
            _title = title;
        }

        public override string ToString()
        {
            return $"{_no} - {_title}";
        }
    }
}
