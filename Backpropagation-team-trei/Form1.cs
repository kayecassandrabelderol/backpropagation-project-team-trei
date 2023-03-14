using Backprop;
using System.Diagnostics;

namespace Backpropagation_team_trei;
public partial class Form1 : Form
{
    NeuralNet nn = new NeuralNet();
    String newFile;
     
    public Form1()
    {
        InitializeComponent();
    }

    private void button1_Click(object sender, EventArgs e)
    {
        nn = new NeuralNet(8, 5, 1);
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
            Debug.WriteLine("Epoch " + i);
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
        double input1 = Convert.ToDouble(comboBox1.SelectedItem.ToString());
        double input2 = Convert.ToDouble(comboBox2.SelectedItem.ToString());
        double input3 = Convert.ToDouble(comboBox3.SelectedItem.ToString());
        double input4 = Convert.ToDouble(comboBox4.SelectedItem.ToString());
        double input5 = Convert.ToDouble(comboBox5.SelectedItem.ToString());
        double input6 = Convert.ToDouble(comboBox6.SelectedItem.ToString());
        double input7 = Convert.ToDouble(comboBox7.SelectedItem.ToString());
        double input8 = Convert.ToDouble(comboBox8.SelectedItem.ToString());

        nn.setInputs(0, input1);
        nn.setInputs(1, input2);
        nn.setInputs(2, input3);
        nn.setInputs(3, input4);
        nn.setInputs(4, input5);
        nn.setInputs(5, input6);
        nn.setInputs(6, input7);
        nn.setInputs(7, input8);
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

    private void saveweight_Click(object sender, EventArgs e)
    {
        //SaveFileDialog saveFileDialog = new SaveFileDialog();
        //saveFileDialog.Filter = "txt files (*.txt)|*.txt";
        string path = "C:\\Users\\Kaye Belderol\\Downloads\\weights.txt";
        
        //if(saveFileDialog.ShowDialog() == DialogResult.Cancel)
        //    return;
        //path = Path.GetFullPath(saveFileDialog1.FileName);
        nn.saveWeights(path);
    }

    private void loadweight_Click(object sender, EventArgs e)
    {
        //using var open = new OpenFileDialog();
        //open.Filter = "txt files (*.txt)|*.txt";
        //open.Title = "Load Weight";

        string path = "C:\\Users\\Kaye Belderol\\Downloads\\weights.txt";

        if (path != string.Empty)
        {
            nn.loadWeights(path);
        }
    }
}