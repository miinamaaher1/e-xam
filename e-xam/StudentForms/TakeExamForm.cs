using BLL.Entities;
using BLL.EntityList;
using BLL.EntityManagers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace e_xam.StudentForms
{
    public partial class TakeExamForm : Form
    {
        Exam exam;
        int studentId;
        int remainingTime;
        public TakeExamForm(int _examId, int _studentId)
        {
            exam = ExamManager.getExam(_examId);
            studentId = _studentId;
            InitializeComponent();
            examTitleLbl.Text = exam.title;
            remainingTime = exam.duration * 60;
            renderExam();
        }

        private void renderExam()
        {
            int number = 1;
            examQuestionsPanel.Controls.Clear();
            foreach (Question question in exam.questions)
            {
                Panel questionPanel = new Panel
                {
                    //Size = new Size(750, 350),
                    AutoSize = true,
                    Padding = new Padding(0, 0, 0, 30)
                };
                Label questionBody = new Label
                {
                    Text = $"{number}: " + question.body,
                    AutoSize = true,
                    Tag = question.id,
                    Location = new Point(10, 10),

                };
                questionPanel.Controls.Add(questionBody);
                if (question.type == 'm')
                {
                    int y = 50;
                    foreach (Option option in question.options)
                    {
                        RadioButton r1 = new RadioButton
                        {
                            Text = option.num + ": " + option.body,
                            //Name = option.num.ToString(),
                            Location = new Point(10, 10 + y),
                            Tag = option.num,
                            Size = new Size(750, 35),
                        };
                        y += 50;
                        questionPanel.Controls.Add(r1);
                    }
                }
                else
                {
                    RadioButton r1 = new RadioButton
                    {
                        Text = "True",
                        Location = new Point(10, 60),
                        Tag = 'T',
                        Size = new Size(750, 35),
                    };
                    RadioButton r2 = new RadioButton
                    {
                        Text = "False",
                        Location = new Point(10, 110),
                        Tag = 'F',
                        Size = new Size(750, 35),
                    };
                    questionPanel.Controls.Add(r1);
                    questionPanel.Controls.Add(r2);
                }
                number++;
                examQuestionsPanel.Controls.Add(questionPanel);
            }
        }
        private void durationTimer_Tick(object sender, EventArgs e)
        {
            if (remainingTime > 0)
            {
                remainingTime--;
                updateLabel();
            }
            else
            {
                durationTimer.Stop();
                finalizeExam();
            }
        }
        private void updateLabel()
        {
            timerLbl.Text = $"{remainingTime / 60:D2}:{remainingTime % 60:D2}";
        }

        private void submitBtn_Click(object sender, EventArgs e)
        {
            finalizeExam();
        }


        private void finalizeExam()
        {
            List<Answer> answerSheet = new List<Answer>();

            foreach (Control outerControl in examQuestionsPanel.Controls)
            {
                if (outerControl is Panel)
                {
                    Answer answer = new Answer();
                    foreach (Control innerControl in outerControl.Controls)
                    {
                        if (innerControl is Label)
                        {
                            answer.questionId = (int)innerControl.Tag;
                        }
                        else if (innerControl is RadioButton && ((RadioButton)innerControl).Checked == true)
                        {
                            answer.answerNum = (char)innerControl.Tag;
                        }
                    }
                    answerSheet.Add(answer);
                }
            }
            double result = AnswerManager.submitAnswers(exam.id, studentId, answerSheet);
            MessageBox.Show($"Your Answers Were Submitted Successfully!\n{result}%");
            this.Close();
        }
    }
}
