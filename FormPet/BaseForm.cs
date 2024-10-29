﻿using System.Windows.Forms;

namespace FormPet
{
    public class BaseForm : Form
    {
        public BaseForm()
        {
            StartPosition = FormStartPosition.CenterScreen;
            this.MaximizeBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }
    }
}
