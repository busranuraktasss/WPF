using System;
using System.Collections.Generic;
using System.Text;

namespace InsertTextTarget
{
    public class BlockedTextBox : ICommand
        //Concreate Command Class 
    {
        Block block;
        public BlockedTextBox(Block block)
        {
            this.block = block;
        }
        public void execute()
        {
            block.blocked();
        }
    }
}
