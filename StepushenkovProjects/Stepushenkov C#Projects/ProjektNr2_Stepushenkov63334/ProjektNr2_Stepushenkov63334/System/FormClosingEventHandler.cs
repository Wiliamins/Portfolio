using System.Windows.Forms;

namespace System
{
    internal class FormClosingEventHandler
    {
        private Action<object, FormClosingEventArgs> exitToolStripMenuItem_FormClosing;

        public FormClosingEventHandler(Action<object, FormClosingEventArgs> exitToolStripMenuItem_FormClosing)
        {
            this.exitToolStripMenuItem_FormClosing = exitToolStripMenuItem_FormClosing;
        }
    }
}