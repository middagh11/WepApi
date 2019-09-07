namespace regEmployee
{
    using System.ComponentModel.DataAnnotations;

    // public enum TypeContact
    //{
    //    ID,
    //  name,
    //  salary,
    // birthday,
    // recommendation,
    //}

    public class Employee
    {
        [Key]
        public int ID { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public int salary { get; set; }
        [Required]
        public DataType birthday { get; set; }
        [Required]
        public string recommendation { get; set; }
        [Display(Description = "Employee")]
        public string ContactValue { get; set; }
    }
}