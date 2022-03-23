using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;


namespace SchoolManagment.Models.MetaClasses
{
    public class CoursesMetaData
    {
        [StringLength(50)]
        public string Title { get; set; }
        [Range(1,8)]
        public int Credidt { get; set; }
    }

    [MetadataType(typeof(CoursesMetaData))]
    public partial class Course
    {

    }

}