using System;
using System.Collections.Generic;
using System.Text;

namespace GradeBook.GradeBooks
{
    public class RankedGradeBook : BaseGradeBook
    {
        public RankedGradeBook(string name): base(name)
        {
            Type = Enums.GradeBookType.Ranked;
        }

        public override char GetLetterGrade(double averageGrade)
        {
            try
            {
                if (Students.Count < 5)
                    throw new InvalidOperationException("Ranked Grading requires a minium of 5 members to work");
                if (averageGrade >= 100 )
                    return 'A';
                else if (averageGrade >= 75 )
                    return 'B';
                else if (averageGrade >= 50 )
                    return 'C';
                else if (averageGrade >= 25 )
                    return 'D';
                else
                    return 'F';
                
            }
            catch (Exception )
            {

                throw;
            }
            
        }

        public override void CalculateStatistics()
        {
            if (Students.Count < 5)
                 Console.WriteLine("Ranked Grading requires at least 5 students with grades in order to properly calculate a student's overall grade");
            else
                base.CalculateStatistics();
        }

        public override void CalculateStudentStatistics(string name)
        {
            if (Students.Count < 5)
                Console.WriteLine("Ranked Grading requires at least 5 students with grades in order to properly calculate a student's overall grade");
            else
                base.CalculateStudentStatistics(name);
        }
    }
}
