using Backprop;

namespace Backpropagation_team_trei;
public partial class Form1 : Form
{
    NeuralNet nn;
     
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
        for (int i = 0; i < Convert.ToInt32(textBox4.Text); i++)
        {
            nn.setInputs(0, 20.00);
            nn.setDesiredOutput(0, 88.60);
            nn.learn();

            nn.setInputs(0, 16);
            nn.setDesiredOutput(0, 71.60);
            nn.learn();

            nn.setInputs(0, 19.80);
            nn.setDesiredOutput(0, 93.30);
            nn.learn();
            
            nn.setInputs(0, 18.40);
            nn.setDesiredOutput(0, 84.30);
            nn.learn();

            nn.setInputs(0, 17.10);
            nn.setDesiredOutput(0, 80.60);
            nn.learn();

            nn.setInputs(0, 15.50);
            nn.setDesiredOutput(0, 75.20);
            nn.learn();

            nn.setInputs(0, 14.70);
            nn.setDesiredOutput(0, 69.70);
            nn.learn();

            nn.setInputs(0, 17.10);
            nn.setDesiredOutput(0, 82.00);
            nn.learn();

            nn.setInputs(0, 15.40);
            nn.setDesiredOutput(0, 69.40);
            nn.learn();

            nn.setInputs(0, 16.20);
            nn.setDesiredOutput(0, 83.30);
            nn.learn();

            nn.setInputs(0, 15);
            nn.setDesiredOutput(0, 79.60);
            nn.learn();

            nn.setInputs(0, 17.20);
            nn.setDesiredOutput(0, 82.60);
            nn.learn();

            nn.setInputs(0, 16);
            nn.setDesiredOutput(0, 80.60);
            nn.learn();

            nn.setInputs(0, 17.00);
            nn.setDesiredOutput(0, 83.50);
            nn.learn();

            nn.setInputs(0, 14.40);
            nn.setDesiredOutput(0, 76.30);
            nn.learn();
        }
    }

    private void button3_Click(object sender, EventArgs e)
    {
        nn.setInputs(0, Convert.ToDouble(textBox1.Text));
        nn.run();
        //double ans = nn.getOuputData(0) ;
        output.Text = "" + nn.getOuputData(0);
    }
}