using BLL.Entities;
using BLL.EntityManagers;
using e_xam.StudentForms;

namespace e_xam
{
    public partial class StudentExams : Form
    {
        List<StudentExam> studentexamlist;
       
        int studentid;
        string cname;
        public StudentExams(int _studentid, int _courseid, int _trakid,string _coursename)
        {
            studentid = _studentid;
            cname = _coursename;
            studentexamlist = StudentManager.getStudetExams(_studentid, _courseid,_trakid);
            InitializeComponent();

            LoudExams();
        }


        private void LoudExams()
        {

            examspanel.Controls.Clear();
            coursename.Text = cname;

            //examspanel.AutoScroll = true;
           
            foreach (StudentExam studexam in studentexamlist)
            {
                Panel examPanel = new Panel
                {
                    Size = new Size(1168, 65),
                    BorderStyle = BorderStyle.FixedSingle,
                    Margin = new Padding(0, 0, 0, 20)
                };

                Label examName = new Label
                {
                    Text = studexam.exam.title,
                    AutoSize = true,
                    Font = new Font("Segoe UI", 14),
                    Location = new Point(30, 15)
                };
              
                Label date = new Label
                {
                   
                   Text = $"Start: {studexam.exam.startDate.ToString("dd/MM/yyyy hh:mm tt")} | End: {studexam.exam.endDate.ToString("dd/MM/yyyy hh:mm tt")}",
                    AutoSize = true,
                    Font = new Font("Segoe UI", 14),
                    Location = new Point(255, 15)
                };

         

                if ((studexam.status == 'm') &&  (studexam.exam.endDate>DateTime.Now) && (studexam.exam.startDate <DateTime.Now))
                {
                    Button btnexam = new Button
                    {

                        Text = "Take",
                        ForeColor = Color.DarkViolet,
                        Size = new Size(115, 45),
                        Location = new Point(1030, 10),
                        Font = new Font("Segoe UI", 14),
                        Tag = studexam.exam.id


                    };

                    btnexam.Click += takeExam_Click;
                    examPanel.Controls.Add(btnexam);
                }
               else if ((studexam.status == 'm') && (studexam.exam.endDate >DateTime.Now )&& (studexam.exam.startDate > DateTime.Now))
                {
                    Button btnexam = new Button
                    {

                        Text = "Take",
                        Size = new Size(115, 45),
                        Location = new Point(1030, 10),
                        Font = new Font("Segoe UI", 14),
                        Tag = studexam.exam.id,
                        Enabled = false


                    };
                    examPanel.Controls.Add(btnexam);
                }

                else if((studexam.status == 'm') &&  (studexam.exam.endDate<DateTime.Now) )
                {
                    Button btnexam = new Button
                    {

                        Text = "Missed",
                        Size = new Size(115, 45),
                        Location = new Point(1030, 10),
                        Font = new Font("Segoe UI", 14),
                        Tag = studexam.exam.id,
                       Enabled = false


                    };
                    examPanel.Controls.Add(btnexam);
                }
                else
                {
                    Button btnexam = new Button
                    {

                        Text = "View",
                        Size = new Size(115, 45),
                        Location = new Point(1030, 10),
                        Font = new Font("Segoe UI", 14),
                        Tag = studexam.exam.id


                    };
                    btnexam.Click += viewExam_Click;
                    examPanel.Controls.Add(btnexam);
                }
                examPanel.Controls.Add(examName);
                examPanel.Controls.Add(date);
               

                examspanel.Controls.Add(examPanel);
            }

        }

        private void takeExam_Click(object sender, EventArgs e)
        {
            Button clickedButton = sender as Button;

            if (clickedButton == null || clickedButton.Tag == null) return;
            else
            {
                int examId = (int)clickedButton.Tag;

                TakeExamForm takeExam = new TakeExamForm( examId,studentid);
                takeExam.FormClosed += (s, args) =>
                {
                    this.Show();
                };
                this.Hide();
                takeExam.Show();
            }
        }


        private void viewExam_Click(object sender, EventArgs e)
        {
            Button clickedButton = sender as Button;

            if (clickedButton == null || clickedButton.Tag == null) return;
            else
            {
                int examId = (int)clickedButton.Tag;

                ReviewAnswersForm answerSheet = new ReviewAnswersForm(studentid, examId);
                answerSheet.FormClosed += (s, args) =>
                {
                    this.Show();
                };
                this.Hide();
                answerSheet.Show();
            }
        }
    }
}
