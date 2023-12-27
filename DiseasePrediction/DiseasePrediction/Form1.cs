using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace DiseasePrediction
{
    public partial class Form1 : Form
    {
        List<Sample> trainSamples;
        List<Sample> testSamples;

        public Form1()
        {
            InitializeComponent();
        }

        private void buttonBrowseTrainFile_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                textBoxTrainFile.Text = openFileDialog1.FileName;
            }
        }

        private void buttonBrowseTestFile_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                textBoxTestFile.Text = openFileDialog1.FileName;
            }
        }

        private void buttonTrainClassFile_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                textBoxTrainClassFile.Text = openFileDialog1.FileName;
            }
        }

        private void buttonReadFiles_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxTrainFile.Text) ||
                string.IsNullOrEmpty(textBoxTrainClassFile.Text) ||
                string.IsNullOrEmpty(textBoxTestFile.Text))
            {
                MessageBox.Show("تمامی فایل ها را انتخاب کنید.");
                return;
            }

            var trainFileArray = File.ReadAllLines(textBoxTrainFile.Text);
            var trainClassesFileArray = File.ReadAllLines(textBoxTrainClassFile.Text);

            trainSamples = new List<Sample>();
            var trainSampleHeader = trainFileArray[0].Split(',');
            for (int i = 1; i < trainSampleHeader.Length; i++)
            {
                trainSamples.Add(new Sample()
                 {
                     ClassName = trainClassesFileArray[i],
                     SampleNumber = trainSampleHeader[i],
                     GeneValues = new List<GeneExpression>(),
                 });
            }
            for (int i = 1; i < trainFileArray.Length; i++)
            {
                var currentGeneValues = trainFileArray[i].Split(',');
                for (int j = 0; j < trainSamples.Count; j++)
                {
                    trainSamples[j].GeneValues.Add(new GeneExpression()
                    {
                        GeneTitle = currentGeneValues[0],
                        Value = Convert.ToInt32(currentGeneValues[j + 1])
                    });
                }
            }

            var testFileArray = File.ReadAllLines(textBoxTestFile.Text);
            testSamples = new List<Sample>();
            var testSampleHeader = testFileArray[0].Split(',');
            for (int i = 1; i < testSampleHeader.Length; i++)
            {
                testSamples.Add(new Sample()
                {
                    SampleNumber = testSampleHeader[i],
                    GeneValues = new List<GeneExpression>(),
                });
            }
            for (int i = 1; i < testFileArray.Length; i++)
            {
                var currentGeneValues = testFileArray[i].Split(',');
                for (int j = 0; j < testSamples.Count; j++)
                {
                    testSamples[j].GeneValues.Add(new GeneExpression()
                    {
                        GeneTitle = currentGeneValues[0],
                        Value = Convert.ToInt32(currentGeneValues[j + 1])
                    });
                }
            }

            MessageBox.Show("فایل ها با موفقیت خوانده شد");
        }

        private void buttonTreshold_Click(object sender, EventArgs e)
        {
            int minTreshold = Convert.ToInt32(numericUpDownMin.Value);
            int maxTreshold = Convert.ToInt32(numericUpDownMax.Value);

            List<string> cleaningGenes = new List<string>();
            foreach (var sample in trainSamples)
            {
                foreach (var gene in sample.GeneValues)
                {
                    if (gene.Value < minTreshold || gene.Value > maxTreshold)
                    {
                        if (!cleaningGenes.Contains(gene.GeneTitle))
                        {
                            cleaningGenes.Add(gene.GeneTitle);
                        }
                    }
                }
            }

            foreach (var sample in testSamples)
            {
                foreach (var gene in sample.GeneValues)
                {
                    if (gene.Value < minTreshold || gene.Value > maxTreshold)
                    {
                        if (!cleaningGenes.Contains(gene.GeneTitle))
                        {
                            cleaningGenes.Add(gene.GeneTitle);
                        }
                    }
                }
            }



            foreach (var sample in trainSamples)
            {
                sample.GeneValues.RemoveAll(g => cleaningGenes.Contains(g.GeneTitle));
            }

            foreach (var sample in testSamples)
            {
                sample.GeneValues.RemoveAll(g => cleaningGenes.Contains(g.GeneTitle));
            }


            MessageBox.Show("عملیات با موفقیت انجام شد");

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < checkedListBoxTopGeneCount.Items.Count; i++)
            {
                checkedListBoxTopGeneCount.SetItemChecked(i, true);
            }
        }

        private void buttonCreateTopGenes_Click(object sender, EventArgs e)
        {
            int foldDifference = Convert.ToInt32(textBoxFoldDifference.Text);
            var cleaningGenes = new List<string>();
            var genes = trainSamples[0].GeneValues.Select(g => g.GeneTitle).ToArray();
            for (int i = 0; i < genes.Length; i++)
            {
                var maxTrainGeneValue = trainSamples.Max(t => t.GeneValues.First(v => v.GeneTitle == genes[i]).Value);
                var minTrainGeneValue = trainSamples.Min(t => t.GeneValues.First(v => v.GeneTitle == genes[i]).Value);
                if ((maxTrainGeneValue - minTrainGeneValue) / minTrainGeneValue < foldDifference)
                {
                    cleaningGenes.Add(genes[i]);
                }

                var maxTestGeneValue = testSamples.Max(t => t.GeneValues.First(v => v.GeneTitle == genes[i]).Value);
                var minTestGeneValue = testSamples.Min(t => t.GeneValues.First(v => v.GeneTitle == genes[i]).Value);
                if ((maxTestGeneValue - minTestGeneValue) / minTestGeneValue < foldDifference)
                {
                    cleaningGenes.Add(genes[i]);
                }

                //var controlAverage = trainSamples.Average(t => t.GeneValues.First(v => v.GeneTitle == genes[i]).Value);
                //var treatAverage = testSamples.Average(t => t.GeneValues.First(v => v.GeneTitle == genes[i]).Value);
                //if ((treatAverage / controlAverage) - 1 < foldDifference)
                //{
                //    cleaningGenes.Add(genes[i]);
                //}
            }

            foreach (var sample in trainSamples)
            {
                sample.GeneValues.RemoveAll(g => cleaningGenes.Contains(g.GeneTitle));
            }

            foreach (var sample in testSamples)
            {
                sample.GeneValues.RemoveAll(g => cleaningGenes.Contains(g.GeneTitle));
            }

            string[] classNames = trainSamples.Select(t => t.ClassName).Distinct().ToArray();
            genes = trainSamples[0].GeneValues.Select(g => g.GeneTitle).ToArray();
            List<GeneClassStandards> standardValues = new List<GeneClassStandards>();
            foreach (var currentGene in genes)
            {
                foreach (var currentClass in classNames)
                {
                    int sumClassGeneValues = 0;
                    int classSampleCount = 0;
                    foreach (var sample in trainSamples.Where(s => s.ClassName == currentClass))
                    {
                        classSampleCount++;
                        sumClassGeneValues += sample.GeneValues.First(g => g.GeneTitle == currentGene).Value;
                    }

                    int classGeneAvarege = sumClassGeneValues / classSampleCount;
                    int sumSubstractionSquare = 0;
                    foreach (var sample in trainSamples.Where(s => s.ClassName == currentClass))
                    {
                        int diff = sample.GeneValues.First(g => g.GeneTitle == currentGene).Value - classGeneAvarege;
                        sumSubstractionSquare += diff * diff;
                    }

                    int deviation = Convert.ToInt32(Math.Sqrt(sumSubstractionSquare / classSampleCount));

                    standardValues.Add(new GeneClassStandards()
                    {
                        ClassName = currentClass,
                        GeneTitle = currentGene,
                        Average = classGeneAvarege,
                        Deviation = deviation,
                    });
                }
            }

            foreach (var sample in trainSamples)
            {
                foreach (var gene in sample.GeneValues)
                {
                    var currentStandard = standardValues.FirstOrDefault(t => t.ClassName == sample.ClassName && t.GeneTitle == gene.GeneTitle);
                    if (currentStandard != null)
                    {
                        gene.NormalValue = ((double)gene.Value - currentStandard.Average) / currentStandard.Deviation;
                    }
                }
            }

            List<TopGenes> topGenes = new List<TopGenes>();

            List<int> topGeneCounts = new List<int>();
            foreach (var item in checkedListBoxTopGeneCount.CheckedItems)
            {
                topGeneCounts.Add(Convert.ToInt32(item));
            }

            foreach (var geneCount in topGeneCounts)
            {
                var currentTopGene = new TopGenes()
                {
                    GeneCount = geneCount,
                    GeneValues = new List<GeneExpression>()
                };

                foreach (var sample in trainSamples)
                {
                    currentTopGene.GeneValues.AddRange(sample.GeneValues.OrderByDescending(v => Math.Abs(v.NormalValue)).Take(geneCount));
                }

                topGenes.Add(currentTopGene);
            }

            foreach (var topGene in topGenes)
            {
                var topGeneTitles = topGene.GeneValues.Select(g => g.GeneTitle).Distinct().ToArray();
                var topNGeneContent = new string[topGeneTitles.Length + 1];
                topNGeneContent[0] = "SNO";

                List<string> arffContents = new List<string>();
                arffContents.Add("@RELATION disease");


                for (int i = 0; i < topGeneTitles.Length; i++)
                {
                    topNGeneContent[i + 1] = topGeneTitles[i];
                    arffContents.Add("@ATTRIBUTE " + topGeneTitles[i] + " NUMERIC");
                }

                arffContents.Add("@ATTRIBUTE class {" + string.Join(",", classNames) + "}");
                arffContents.Add("@DATA");

                foreach (var sample in trainSamples)
                {
                    topNGeneContent[0] += "," + sample.SampleNumber;
                    string currentSampleGeneValues = "";
                    for (int i = 0; i < topGeneTitles.Length; i++)
                    {
                        var currentGeneValue = sample.GeneValues.First(v => v.GeneTitle == topGeneTitles[i]).Value;//.NormalValue;
                        topNGeneContent[i + 1] += "," + currentGeneValue;
                        currentSampleGeneValues += currentGeneValue + ",";
                    }

                    arffContents.Add(currentSampleGeneValues + sample.ClassName);

                }

                File.WriteAllLines("pp5i_train.top" + topGene.GeneCount + ".gr.csv", topNGeneContent);
                File.WriteAllLines("pp5i_train.top" + topGene.GeneCount + ".gr.arff", arffContents);

            }

            MessageBox.Show("عملیات با موفقیت انجام شد");
        }

        private void buttonBrowseBestTrain_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                textBoxBestTrainFile.Text = openFileDialog1.FileName;
            }
        }

        private void buttonTestGeneExtrat_Click(object sender, EventArgs e)
        {
            if (File.Exists(textBoxBestTrainFile.Text))
            {
                string[] classNames = trainSamples.Select(t => t.ClassName).Distinct().ToArray();
                var bestTrainNContent = File.ReadAllLines(textBoxBestTrainFile.Text);
                List<string> topGeneTitles = new List<string>();
                for (int i = 1; i < bestTrainNContent.Length; i++)
                {
                    topGeneTitles.Add(bestTrainNContent[i].Split(',')[0]);
                }

                var topNGeneContent = new string[topGeneTitles.Count + 1];
                topNGeneContent[0] = "SNO";

                List<string> arffContents = new List<string>();
                arffContents.Add("@RELATION disease");


                for (int i = 0; i < topGeneTitles.Count; i++)
                {
                    topNGeneContent[i + 1] = topGeneTitles[i];
                    arffContents.Add("@ATTRIBUTE " + topGeneTitles[i] + " NUMERIC");
                }

                arffContents.Add("@ATTRIBUTE class {" + string.Join(",", classNames) + "}");
                arffContents.Add("@DATA");

                foreach (var sample in testSamples)
                {
                    topNGeneContent[0] += "," + sample.SampleNumber;
                    string currentSampleGeneValues = "";
                    for (int i = 0; i < topGeneTitles.Count; i++)
                    {
                        var currentGeneValue = sample.GeneValues.First(v => v.GeneTitle == topGeneTitles[i]).Value;//.NormalValue;
                        topNGeneContent[i + 1] += "," + currentGeneValue;
                        currentSampleGeneValues += currentGeneValue + ",";
                    }

                    arffContents.Add(currentSampleGeneValues + "?");

                }
                int geneCount = 0;
                if (radioButtonTop2.Checked)
                {
                    geneCount = 2;
                }
                else if (radioButtonTop4.Checked)
                {
                    geneCount = 4;
                }
                else if (radioButtonTop6.Checked)
                {
                    geneCount = 6;
                }
                else if (radioButtonTop8.Checked)
                {
                    geneCount = 8;
                }
                else if (radioButtonTop10.Checked)
                {
                    geneCount = 10;
                }
                else if (radioButtonTop12.Checked)
                {
                    geneCount = 12;
                }
                else if (radioButtonTop15.Checked)
                {
                    geneCount = 15;
                }
                else if (radioButtonTop20.Checked)
                {
                    geneCount = 20;
                }
                else if (radioButtonTop25.Checked)
                {
                    geneCount = 25;
                }
                else if (radioButtonTop30.Checked)
                {
                    geneCount = 30;
                }
                File.WriteAllLines("pp5i_test.best" + geneCount + ".csv", topNGeneContent);
                File.WriteAllLines("pp5i_test.best" + geneCount + ".arff", arffContents);

            }
        }

    }
}
