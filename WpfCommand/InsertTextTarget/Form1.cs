// // Copyright (c) Microsoft. All rights reserved.
// // Licensed under the MIT license. See LICENSE file in the project root for full license information.

using InsertTextTarget;
using System;
using System.Windows.Forms;

namespace InsertTextW32Target
{
    public partial class Target : Form
    {
        
        public Target()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            //Client sýnýfý
            //Invoker sýnýfýmýzý burda çaðýrýyoruz.
            if(checkBox1.Checked == true)
            { 
                tbTargetMultiLine.Enabled = (checkBox1.CheckState != CheckState.Checked);
                SimpleRemoteControl remote = new SimpleRemoteControl();
                Block block = new Block();
                BlockedTextBox block1 = new BlockedTextBox(block);
                remote.setCommand(block1);
                remote.buttonWasPressed();

            }
            else
            {
                tbTargetMultiLine.Enabled = (checkBox1.CheckState != CheckState.Checked);
                SimpleRemoteControl remote = new SimpleRemoteControl();
                Block block = new Block();
                UnBlockedTextBox block2 = new UnBlockedTextBox(block);
                remote.setCommand(block2);
                remote.buttonWasPressed();
            }


        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked == true)
            {
                rtbTarget.Enabled = (checkBox2.CheckState != CheckState.Checked);
                SimpleRemoteControl remote = new SimpleRemoteControl();
                Block block = new Block();
                BlockedTextBox block1 = new BlockedTextBox(block);
                remote.setCommand(block1);
                remote.buttonWasPressed();

            }
            else
            {
                rtbTarget.Enabled = (checkBox2.CheckState != CheckState.Checked);
                SimpleRemoteControl remote = new SimpleRemoteControl();
                Block block = new Block();
                UnBlockedTextBox block2 = new UnBlockedTextBox(block);
                remote.setCommand(block2);
                remote.buttonWasPressed();
            }


        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            tbTarget.Enabled = (checkBox3.CheckState != CheckState.Checked);
            if (checkBox3.Checked == true)
            {
                tbTarget.Enabled = (checkBox3.CheckState != CheckState.Checked);
                SimpleRemoteControl remote = new SimpleRemoteControl();
                Block block = new Block();
                BlockedTextBox block1 = new BlockedTextBox(block);
                remote.setCommand(block1);
                remote.buttonWasPressed();

            }
            else
            {
                tbTarget.Enabled = (checkBox3.CheckState != CheckState.Checked);
                SimpleRemoteControl remote = new SimpleRemoteControl();
                Block block = new Block();
                UnBlockedTextBox block2 = new UnBlockedTextBox(block);
                remote.setCommand(block2);
                remote.buttonWasPressed();
            }

        }
    }
}