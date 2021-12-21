using System;
using System.Collections.Generic;
using System.Text;

namespace InsertTextTarget
{
    public class UnBlockedTextBox :ICommand
        //Concreate Command Class 
    {
        Block block;
            public UnBlockedTextBox(Block block)
            {
                this.block = block;
            }
            public void execute()
            {
                block.unblocked();
            }
        }
    
}
