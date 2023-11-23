using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BooruToA1111
{
    public static class MyUtil
    {
        /// <summary>
        /// パスからディレクトリ名を除去する。実際には最後のスラッシュより前を消す
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static string RemoveDirectoryName(string str)
        {
            if (string.IsNullOrEmpty(str))
                return string.Empty;

            int last = str.LastIndexOf("\\");
            if (last == -1)
            {
                last = str.LastIndexOf("/");
            }

            if (last == -1)
            {
                return string.Empty;
            }

            return str.Remove(0, last + 1);
        }

        /// <summary>
        /// パスからファイル名を除去する。実際には最後のスラッシュより後ろを消す
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static string RemoveFileName(string str, bool KeepLastChar = true)
        {
            if (string.IsNullOrEmpty(str))
                return string.Empty;

            int last = str.LastIndexOf("\\");
            if (last == -1)
            {
                last = str.LastIndexOf("/");
            }

            if (last == -1)
            {
                return string.Empty;
            }
            int num = last;
            if (KeepLastChar)
                num += 1;


            return str.Remove(num);
        }
    }
}
