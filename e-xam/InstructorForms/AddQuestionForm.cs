using BLL.Entities;
using BLL.EntityManagers;

namespace e_xam
{

    enum QuestionType
    {
        MCQ_Question,
        TF_Question
    }
    public partial class AddQuestionForm : Form
    {
        private int course_id;
        private int inst_id;
        public AddQuestionForm(int _course_id, int _inst_id)
        {
            InitializeComponent();
            typeComboBox.Items.Add(QuestionType.MCQ_Question);
            typeComboBox.Items.Add(QuestionType.TF_Question);
            typeComboBox.SelectedIndex = 0;
            tOrFGrpBox.Enabled = false;
            typeComboBox.SelectedIndexChanged += TypeComboBox_SelectedIndexChanged;
            markTxtBox.KeyPress += MarkTxtBox_KeyPress;
            course_id = _course_id;
            inst_id = _inst_id;

        }

        private void TypeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ((QuestionType)typeComboBox.SelectedItem == QuestionType.MCQ_Question)
            {
                tOrFGrpBox.Enabled = false;
                mcqGrpBx.Enabled = true;
            }
            else
            {
                mcqGrpBx.Enabled = false;
                tOrFGrpBox.Enabled = true;
            }
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            Question question = new Question();
            if ((QuestionType)typeComboBox.SelectedItem == QuestionType.TF_Question)
            {
                question.body = bodyTxtBox.Text;
                question.mark = Convert.ToInt32(markTxtBox.Text);
                question.type = 't';
                if (trueRadBtn.Checked)
                {
                    question.ans = 'T';
                }
                else
                {
                    question.ans = 'F';
                }
                question.course = new Course();
                question.course.id = course_id;
                QuestionManager.addTFQuestion(question);
                MessageBox.Show("Question Added Successfully");

                AddQCourseSelectionForm addQCourseSelectionForm = new AddQCourseSelectionForm(inst_id);
                addQCourseSelectionForm.FormClosed += (s, args) =>
                {
                    // Show the current form again
                    this.Show();
                };
                this.Hide();
                addQCourseSelectionForm.Show();
            }
            else
            {
                question.body = bodyTxtBox.Text;
                question.mark = Convert.ToInt32(markTxtBox.Text);
                question.type = 'm';
                if (optionARadBtn.Checked)
                {
                    question.ans = 'A';
                }
                else if (optionBRadBtn.Checked)
                {
                    question.ans = 'B';
                }
                else if (optionCRadBtn.Checked)
                {
                    question.ans = 'C';
                }
                else
                {
                    question.ans = 'D';
                }
                question.course = new Course();
                question.course.id = course_id;
                question.options = new List<Option>();

                question.options.Add(new Option() { body = optionATxtBox.Text });
                question.options.Add(new Option() { body = optionBTxtBox.Text });
                question.options.Add(new Option() { body = optionCTxtBox.Text });
                question.options.Add(new Option() { body = optionDTxtBox.Text });

                QuestionManager.addMCQQuestion(question);
                MessageBox.Show("Question Added Successfully");

                AddQCourseSelectionForm addQCourseSelectionForm = new AddQCourseSelectionForm(inst_id);
                addQCourseSelectionForm.FormClosed += (s, args) =>
                {
                    // Show the current form again
                    this.Show();
                };
                this.Hide();
                addQCourseSelectionForm.Show();
            }

        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            AddQCourseSelectionForm addQCourseSelectionForm = new AddQCourseSelectionForm(inst_id);

            addQCourseSelectionForm.FormClosed += (s, args) =>
            {
                // Show the current form again
                this.Show();
            };
            this.Hide();
            addQCourseSelectionForm.Show();
        }
        private void MarkTxtBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // ignore the key
            }
        }
    }
}