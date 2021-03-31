using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace LMS.DATA.EF
{
    #region Choice Metadata

    public class ChoiceMetadata
    {
        [Display(Name = "Question Choice")]
        [Required(ErrorMessage = "*Question Choice required")]
        [StringLength(200, ErrorMessage = "*Must be 200 characteres or less")]
        public string ChoiceDescription { get; set; }
        
        public int QuestionId { get; set; }

        [Display(Name = "Correct Answer")]
        [Required(ErrorMessage = "*Correct Answer required")]
        public bool IsCorrect { get; set; }
    }

    [MetadataType(typeof(ChoiceMetadata))]

    public partial class Choice
    {

    }

    #endregion

    #region Course Metadata

    public class CourseMetadata
    {
        [Display(Name = "Course Name")]
        [Required(ErrorMessage = "*Course Name required")]
        [StringLength(200, ErrorMessage = "*Must be 200 characteres or less")]
        public string CourseName { get; set; }

        [Display(Name = "Course Description")]
        [Required(ErrorMessage = "*Course Description required")]
        [UIHint("MultilineText")]
        [StringLength(500, ErrorMessage = "*Must be 500 characteres or less")]
        public string CourseDescription { get; set; }

        [Display(Name = "Is Active")]
        [Required(ErrorMessage = "*Is Active required")]
        public bool IsActive { get; set; }
    }

    [MetadataType(typeof(CourseMetadata))]

    public partial class Course
    {

    }

    #endregion

    #region Course Completion Metadata

    public class CourseCompletionMetadata
    {
        public string UserId { get; set; }
        public int CourseId { get; set; }

        [Display(Name = "Date Completed")]
        [Required(ErrorMessage = "*Date Completed required")]
        public System.DateTime DateCompleted { get; set; }
    }

    [MetadataType(typeof(CourseCompletionMetadata))]

    public partial class CourseCompletion
    {

    }

    #endregion

    #region Lesson Metadata

    public class LessonMetadata
    {
        [Display(Name = "Lesson Title")]
        [Required(ErrorMessage = "*Lesson Title required")]
        [StringLength(200, ErrorMessage = "*Must be 200 characteres or less")]
        public string LessonTitle { get; set; }

        public int CourseId { get; set; }

        [Required(ErrorMessage = "*Introduction required")]
        [StringLength(300, ErrorMessage = "*Must be 300 characteres or less")]
        [UIHint("MultilineText")]
        public string Introduction { get; set; }

        [Display(Name = "Video URL")]
        [Required(ErrorMessage = "*Video URL required")]
        [StringLength(250, ErrorMessage = "*Must be 250 characteres or less")]
        public string VideoURL { get; set; }

        [Display(Name = "PDF File Name")]
        [StringLength(100, ErrorMessage = "*Must be 100 characteres or less")]
        public string PdfFilename { get; set; }

        [Display(Name = "Is Active")]
        [Required(ErrorMessage = "*Is Active required")]
        public bool IsActive { get; set; }
    }

    [MetadataType(typeof(LessonMetadata))]

    public partial class Lesson
    {

    }

    #endregion

    #region Lesson Views Metadata


    public class LessonViewMetadata
    {
        public string UserId { get; set; }
        public int LessonId { get; set; }

        [Display(Name = "Date Viewed")]
        [DisplayFormat(DataFormatString = "{0:d}")]
        public System.DateTime DateViewed { get; set; }
    }

    [MetadataType(typeof(LessonViewMetadata))]

    public partial class LessonView
    {
        [Display(Name = "Name")]
        public string Name
        {
            get { return $"{UserDetail.FirstName} {UserDetail.LastName}"; }
        }

        public string Course
        {
            get { return Lesson.Course.CourseName; }
        }
    }

    #endregion

    #region Lesson Completion Metadata

    public class LessionCompletionMetadata
    {
        public string UserId { get; set; }

        [DisplayFormat(DataFormatString = "{0:d}")]
        public System.DateTime DateCompleted { get; set; }
        public int LessonId { get; set; }
    }

    [MetadataType(typeof(LessionCompletionMetadata))]

    public partial class LessonCompletion
    {
        [Display(Name = "Name")]
        public string Name
        {
            get { return $"{UserDetail.FirstName} {UserDetail.LastName}"; }
        }

        [Display(Name = "Lesson")]
        public string LessonTitle
        {
            get { return Lesson.LessonTitle; }
        }

        [Display(Name = "Course")]
        public string Course
        {
            get { return Lesson.Course.CourseName; }
        }
    }

    #endregion

    #region Question Metadata

    public class QuestionMetadata
    {
        [Display(Name = "Question Desctiption")]
        [Required(ErrorMessage = "*Question Description required")]
        [StringLength(500, ErrorMessage = "*Must be 500 characteres or less")]
        public string QuestionDescription { get; set; }

        public int LessonId { get; set; }
    }

    [MetadataType(typeof(QuestionMetadata))]

    public partial class Question
    {

    }

    #endregion

    #region Test Score Metadata

    public class TestScoreMetadata
    {
        public string UserId { get; set; }
        public int LessonId { get; set; }

        [Required(ErrorMessage = "*Score required")]
        public double Score { get; set; }
    }

    #endregion

    #region User Detail Metadata

    public class UserDetailMetadata
    {
        [Display(Name = "First Name")]
        [Required(ErrorMessage = "*First Name required")]
        [StringLength(50, ErrorMessage = "*Must be 50 characteres or less")]
        public string FirstName { get; set; }

        [Display(Name = "Last Name")]
        [Required(ErrorMessage = "*Last Name required")]
        [StringLength(50, ErrorMessage = "*Must be 50 characteres or less")]
        public string LastName { get; set; }

        [Display(Name = "Manager")]
        [DisplayFormat(NullDisplayText = "[N/A]")]
        public string ManagerId { get; set; }
    }

    [MetadataType(typeof(UserDetailMetadata))]

    public partial class UserDetail
    {
        public string FullName
        {
            [Display(Name = "Full Name")]
            get { return $"{FirstName} {LastName}"; }
        }

        [Display(Name = "Manager")]
        public string UserManager
        {
            get { return $"{UserDetail1.FirstName} {UserDetail1.LastName}"; }
        }
    }
    #endregion

}
