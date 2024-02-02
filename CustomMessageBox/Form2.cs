using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;

namespace CustomMessageBox {
    /// <summary>
    /// The form internally used by <see cref="CustomMessageBox"/> class.
    /// </summary>
    internal partial class Form2 : Form {
        /// <summary>
        /// This constructor is required for designer support.
        /// </summary>
        public Form2() {
            InitializeComponent();
        }


        public Form2(int x, int y) {

            InitializeComponent();

            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(x, y);

        }
    }

    /// <summary>
    /// Your custom message box helper.
    /// </summary>
    public static class CustomMessageBox {
        public static void Show() {
            // using construct ensures the resources are freed when form is closed
            using var form = new Form2();
            form.ShowDialog();
        }

        public static void Show(int x, int y) {
            // using construct ensures the resources are freed when form is closed
            var form = new Form2(x, y);
            form.ShowDialog();
            form.Dispose();
        }
    }
}