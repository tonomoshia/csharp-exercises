using System;
using System.Collections.Generic;
using System.Text;

namespace Question
{
    public class Question
    {
        public string question;
        public int score;

        public Question(string question)
        {
            this.question = question;
        }

        public Question(string question, int score) : this(question)
        {
            this.score = score;
        }
        public abstract int runQuestion();
    }
}
