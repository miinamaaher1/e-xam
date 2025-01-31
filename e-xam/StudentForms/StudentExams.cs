using BLL.Entities;
using BLL.EntityManagers;
using e_xam.StudentForms;

namespace e_xam
{
    public partial class StudentExams : Form
    {
        List<StudentExam> studentexamlist;
        int x;
        int y;
        int v;
        int z ;
       
        int studentid;
        string cname;
        public StudentExams(int _studentid, int _courseid, int _trakid,string _coursename)
        {
            studentid = _studentid;
            cname = _coursename;
            x = y = z = v = 0;
            studentexamlist = StudentManager.getStudetExams(_studentid, _courseid,_trakid);
            InitializeComponent();

            LoudExams();
        }


        private void LoudExams()
        {

            examspanel.Controls.Clear();
            coursename.Text = cname;
            coursename.Font = new Font("Arial", 15, FontStyle.Bold);
            
            examspanel.Size = new Size(800, 1000);
            examspanel.AutoScroll = true;
           
            foreach (StudentExam exam in studentexamlist)
            {


                Panel examPanel = new Panel
                {
                    Size = new Size(800, 50),
                    BorderStyle = BorderStyle.Fixed3D,
                    Location = new Point(10,60+z)
                };
                Label examName = new Label
                {
                    Text = exam.exam.title,
                    AutoSize = true,
                    Font = new Font("Arial", 10, FontStyle.Bold),
                    Location = new Point(10, 10+y)
                };
              
                Label date = new Label
                {
                   
                   Text = $"start: {exam.exam.startDate:G} | End: {exam.exam.endDate:G}",
                    AutoSize = true,
                    Font = new Font("Arial", 10, FontStyle.Bold),
                    Location = new Point(120 , 10 + x)
                };

         

                if ((exam.status == 'm') &&  (exam.exam.endDate>DateTime.Now) && (exam.exam.startDate <DateTime.Now))
                {
                    Button btnexam = new Button
                    {

                        Text = "Take",
                        Size = new Size(80, 30),
                        Location = new Point(600, 5+v),
                        Tag = exam.exam.id


                    };

                    btnexam.Click += takeExam_Click;
                    examPanel.Controls.Add(btnexam);
                }
               else if ((exam.status == 'm') && (exam.exam.endDate >DateTime.Now )&& (exam.exam.startDate > DateTime.Now))
                {
                    Button btnexam = new Button
                    {

                        Text = "Take",
                        Size = new Size(80, 30),
                        Location = new Point(600, 5 + v),
                        Tag = exam.exam.id,
                        Enabled = false


                    };
                    examPanel.Controls.Add(btnexam);
                }

                else if((exam.status == 'm') &&  (exam.exam.endDate<DateTime.Now) )
                {
                    Button btnexam = new Button
                    {

                        Text = "missed",
                        Size = new Size(80, 30),
                        Location = new Point(600, 5 + v), 
                        Tag = exam.exam.id,
                       Enabled = false


                    };
                    examPanel.Controls.Add(btnexam);
                }
                else
                {
                    Button btnexam = new Button
                    {

                        Text = "view",
                        Size = new Size(80, 30),
                        Location = new Point(600 ,  5+v),
                        Tag = exam.exam.id


                    };
                    btnexam.Click += viewExam_Click;
                    examPanel.Controls.Add(btnexam);
                }
                examPanel.Controls.Add(examName);
                examPanel.Controls.Add(date);
               



                examspanel.Controls.Add(examPanel);

               
              
            }

            x += 10;
            y += 10;
            z += 50;
            v += 5;


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
