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
        public TakeExamForm(int _id)
        {
            exam = ExamManager.getExam(_id);
            InitializeComponent();
            examTitleLbl.Text = exam.title;
            renderExam();
        }

        private void renderExam()
        {
            int number = 1;
            int y = 0;
            examQuestionsPanel.Controls.Clear();
            foreach(Question question in exam.questions)
            {
                Panel questionPanel = new Panel
                {
                    Size = new Size(750, 350),
                    Tag = question.id,

                };
                Label questionBody = new Label
                {
                    Text = $"{number}: " + question.body,
                    AutoSize = true,
                    Location = new Point(10,10 + y)
                };
                questionPanel.Controls.Add(questionBody);
                if (question.type == 'm')
                {
                    int yy = 5;
                    foreach (Option option in question.options)
                    {
                        RadioButton r1 = new RadioButton
                        {
                            Text = option.num + ": " + option.body,
                            //Name = option.num.ToString(),
                            Location = new Point(10,10 + y + yy),
                            Tag = option.num,
                        };
                        yy += 5;
                        questionPanel.Controls.Add(r1);
                    }
                } else
                {
                    RadioButton r1 = new RadioButton
                    {
                        Text = "True",
                        //Name = option.num.ToString(),
                        Location = new Point(10, 15 + y),
                        Tag = 'T',
                    };
                    RadioButton r2 = new RadioButton
                    {
                        Text = "False",
                        //Name = option.num.ToString(),
                        Location = new Point(10, 15 + y),
                        Tag = 'F',
                    };
                    questionPanel.Controls.Add(r1);
                    questionPanel.Controls.Add(r2);
                }
                number++;
                y += 10;
                examQuestionsPanel.Controls.Add(questionPanel);
            }
        }
    }
}
