using Backprop;

namespace Backpropagation_team_trei;
public partial class Form1 : Form
{
    NeuralNet nn;
    String newFile;
     
    public Form1()
    {
        InitializeComponent();
    }

    private void button1_Click(object sender, EventArgs e)
    {
        nn = new NeuralNet(1, 4, 1);
    }

    private void button2_Click(object sender, EventArgs e)
    {
        var data = File.ReadAllLines(newFile)
            .Skip(1)
            .Select(row => row.Split(','))
            .Select(row => new
            {
                Inputs = row.Take(row.Length - 1).Select(float.Parse).ToArray(),
                Output = float.Parse(row.Last())
            })
            .ToArray();

        for (int i = 0; i < Convert.ToInt32(textBox4.Text); i++)
        {
            foreach (var row in data)
            {
                nn.setInputs(0, row.Inputs[0]);
                nn.setInputs(1, row.Inputs[1]);
                nn.setInputs(2, row.Inputs[2]);
                nn.setInputs(3, row.Inputs[3]);
                nn.setInputs(4, row.Inputs[4]);
                nn.setInputs(5, row.Inputs[5]);
                nn.setInputs(6, row.Inputs[6]);
                nn.setInputs(7, row.Inputs[7]);
                nn.setDesiredOutput(0, row.Output);
                nn.learn();
            }
        }
    }

    private void button3_Click(object sender, EventArgs e)
    {
        //nn.setInputs(0, Convert.ToDouble(textBox1.Text));
        nn.run();
        //double ans = nn.getOuputData(0) ;
        output.Text = "" + nn.getOuputData(0);
    }

    private void openFileToolStripMenuItem_Click(object sender, EventArgs e)
    {
        openFileDialog1.ShowDialog();

    }

    private void openFileDialog1_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
    {
        newFile = openFileDialog1.FileName;
    }
}