using System;
using System.Collections.Generic;

namespace DictionaryExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> students = new Dictionary<int, string>()
            {
                {1, "Alice" },
                {2, "Bob" },
                {3, "Charlie" }
            };

            Console.WriteLine("학생 목록:");
            foreach (KeyValuePair<int, string> student in students)
            {
                Console.WriteLine($"ID:{student.Key}, Name:{student.Value}");                
            }

            // Key 값으로 배열처럼 접근할 수 있음
            Console.WriteLine($"ID 2 학생 이름: {students[2]}");

            students.Add(4, "David");
            Console.WriteLine("ID 4 학생 추가됨.");

            students.Remove(1);
            Console.WriteLine("ID 1 학생 제거됨");

            Console.WriteLine("최종 학생 목록:");
            foreach (KeyValuePair<int, string> student in students)
            {
                Console.WriteLine($"ID:{student.Key}, Name:{student.Value}");
            }
        }

    }
}
