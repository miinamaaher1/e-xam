using BLL.Entities;
using BLL.EntityManagers;
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
                    AutoSize = false,
                    Width = this.ClientSize.Width - 20,
                    Padding = new Padding(0, 0, 0, 30)
                };
                Label questionBody = new Label
                {
                    AutoSize = false, // Manual control over size
                    Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right, // Resizes with window
                    Text = $"{number}: " + question.body,
                    MaximumSize = new Size(this.ClientSize.Width - 40, 0),  // Full width minus padding
                    Width = this.ClientSize.Width - 40,  // Update width initially
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
                            AutoSize = false, // Manual control over size
                            Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right, // Resizes with window
                            Text = option.num + ": " + option.body,
                            MaximumSize = new Size(this.ClientSize.Width - 40, 0),  // Full width minus padding
                            Width = this.ClientSize.Width - 40,  // Update width initially
                            Location = new Point(10, 10 + y),
                            Tag = option.num,
                        };
                        y += 50;
                        questionPanel.Controls.Add(r1);
                    }
                }
                else
                {
                    RadioButton r1 = new RadioButton
                    {
                        AutoSize = false, // Manual control over size
                        Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right, // Resizes with window
                        Text = "True",
                        MaximumSize = new Size(this.ClientSize.Width - 40, 0),  // Full width minus padding
                        Width = this.ClientSize.Width - 40,  // Update width initially
                        Location = new Point(10, 60),
                        Tag = 'T',
                    };
                    RadioButton r2 = new RadioButton
                    {
                        AutoSize = false, // Manual control over size
                        Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right, // Resizes with window
                        Text = "False",
                        MaximumSize = new Size(this.ClientSize.Width - 40, 0),  // Full width minus padding
                        Width = this.ClientSize.Width - 40,  // Update width initially
                        Location = new Point(10, 110),
                        Tag = 'F',
                    };
                    questionPanel.Controls.Add(r1);
                    questionPanel.Controls.Add(r2);
                }
                number++;
                examQuestionsPanel.Controls.Add(questionPanel);
                questionPanel.Height = questionPanel.PreferredSize.Height;

                // set height dynamically
                foreach (Control control in questionPanel.Controls)
                {
                    control.Height = control.PreferredSize.Height;
                }
            }
        }
        private void durationTimer_Tick(object sender, EventArgs e)
        {
            if (remainingTime > 0)
            {
                remainingTime--;
                updateTimerLabel();
            }
            else
            {
                durationTimer.Stop();
                finalizeExam();
            }
        }
        private void updateTimerLabel()
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

            foreach (Control panel in examQuestionsPanel.Controls)
            {
                if (panel is Panel)
                {
                    Answer answer = new Answer();
                    foreach (Control control in panel.Controls)
                    {
                        if (control is Label)
                        {
                            answer.questionId = (int)control.Tag;
                        }
                        else if (control is RadioButton && ((RadioButton)control).Checked == true)
                        {
                            answer.answerNum = (char)control.Tag;
                        }
                    }
                    answerSheet.Add(answer);
                }
            }
            double result = AnswerManager.submitAnswers(exam.id, studentId, answerSheet);
            MessageBox.Show($"Your Answers Were Submitted Successfully!\n{result}%");
            this.Close();
        }

        private void TakeExamForm_Resize(object sender, EventArgs e)
        {
            foreach (Control panel in examQuestionsPanel.Controls)
            {
                if (panel is Panel)
                {
                    foreach (Control control in panel.Controls)
                    {
                        control.Width = this.ClientSize.Width - 40;
                        control.MaximumSize = new Size(this.ClientSize.Width - 40, 0);
                        control.Height = control.PreferredSize.Height;
                        this.PerformLayout();
                    }
                }
            }
        }
    }
}
