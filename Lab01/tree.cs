using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab01
{
    public partial class tree : Component
    {
        public tree()
        {
            InitializeComponent();
        }

        public tree(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }
    }
}
