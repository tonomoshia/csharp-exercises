using System;
using System.Collections.Generic;
using System.Text;

namespace Quiz
{
    public class Question
    {
        public string question;

        public static addQuestion(q);
    }
    // Multiple Choice: a question with a fixed set of possible answers, of which only one may be chosen and only one answer is correct
    public class MultipleChoiceQuestion : Question
    {

    }
    // Checkbox: a question with a fixed set of possible answers, of which any number may be chosen; there is one correct combination of choices
    public class CheckboxQuestion : Question
    {

    }
    // True?false: a question that has a true/false answer
    public class TrueFalseQuestion : Question
    {
        readonly bool answer;
    }
}
