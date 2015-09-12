using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using StringMixerUtils;

namespace Interactive_String_Mixer
{
  public partial class Form1 : Form
  {
    public Form1()
    {
      InitializeComponent();
    }

    private void button1_Click(object sender, EventArgs e)
    {
      char[] input = inputBox.Text.ToCharArray();
      string res = StringReverser.Reverse(input);
      resultBox.Text = res;
    }

    private void button2_Click(object sender, EventArgs e)
    {
      char[] input = inputBox.Text.ToCharArray();
      string res = CaseSwitcher.CaseSwitch(input);
      resultBox.Text = res;
    }

    private void button3_Click(object sender, EventArgs e)
    {
      char[] input = inputBox.Text.ToCharArray();
      string res = Randomizer.Randomize(input);
      resultBox.Text = res;
    }

  }
}
