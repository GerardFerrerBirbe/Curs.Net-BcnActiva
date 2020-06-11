using System;
using System.Collections.Generic;
using System.Text;

namespace ExerciciVIDEOS
{
    public class ValidationResult<T>
    {
        public T ValidatedResult {get; set; }
        
        public bool IsSuccess { get; set; }

        public List<string> Errors { get; set; } = new List<string>();        
    }
}
