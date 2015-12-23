using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algrthm.LanguageFeatures.Enumerator
{
    public class StudentCollection : IEnumerator, IEnumerable
    {
        ArrayList StudList = new ArrayList();

        private int Position = -1;

        public void AddStudent(Student std)
        {
            StudList.Add(std);
        }


        public object Current
        {
            get
            {
                return StudList[Position];
            }

        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public bool MoveNext()
        {
            if (Position < StudList.Count - 1)
            {
                ++Position;
                return true;
            }
            return false;
        }



        public void Reset()
        {
            Position = -1;
        }

        public IEnumerator GetEnumerator()
        {
            return (IEnumerator)this;

        }
    }
}
