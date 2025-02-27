namespace LeetCode
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //CustomStack stk = new CustomStack(3); // Stack is Empty []            

            //Stack<string> tets = new Stack<string>();

            //stk.Push(1);
            //stk.Pop();
            int[] nums = new int[] { 2, 7, 11, 15 };
            int target = 9;
            LinqPractice linqPractice = new LinqPractice();
            LeetCode leetCode = new LeetCode();
            var test1 = leetCode.TwoSum(nums, target);
            //var test1 = linqPractice.GetStudentFirstNameOfGroupTwo();
            //var test2 = linqPractice.GetStudentNameLexicographically();
            //var tes2 = linqPractice.GetStudentByAge();
            //var test3 = linqPractice.GetStudentByAscendingAndDescendingOrder();
            //var test4 = linqPractice.GetStudentByPhoneNumber();
            //var test = linqPractice.GetStudentByEmailDomain();
            //var test = linqPractice.GetExcelentStudent();
            //var test = linqPractice.GetWeakStudent();
            //var test = linqPractice.GetStudentEnrolledYear();
            //var test = linqPractice.GetNameByAsecdingGroup();
            //int [] arraynews = new int[] { 3, 2, 3 };
            //LeetCode leetCode = new LeetCode();
            //var result =leetCode.TwoSum(arraynews, 6);

            //List<IEnumerable<string>> allTests = new List<IEnumerable<string>> { test1, test2, tes2, test3, test4,test5 };

            //foreach (var test in allTests)
            //{
            //    foreach (var item in test)
            //    {
            //        Console.WriteLine(item);
            //    }
            //}

            //foreach (var item in test)
            //{
            //    Console.WriteLine(item);

            //}



            int[] input = new int[] { 2, 2, 1 };
            MyHashMap myHashMap = new MyHashMap();

            var result = myHashMap.IsHappy(19);


            //myHashMap.SingleNumber(input);
        }

    }
}


//Wrong Answer
//Runtime: 93 ms
//Case 1
//Input
//["CustomStack","push","push","pop","push","push","push","increment","increment","pop","pop","pop","pop"]
//[[3],[1],[2],[],[2],[3],[4],[5,100],[2,100],[],[],[],[]]
//Stdout
//Pushed 1 onto the stack.
//Pushed 2 onto the stack.
//Pushed 2 onto the stack.
//Stck is full
//Stck is full
//Output
//[null,null,null,2,null,null,null,null,null,102,102,102,102]
//Expected
//[null, null, null, 2, null, null, null, null, null, 103, 202, 201, -1]