﻿namespace Module_Control_2._1_Working_with_files
{
    class TextFile: BaseFile
    {
        public string Content { get; set; }

        public override string ToString()
        {
            return $"{base.ToString()}" + $"B\n\t\tContent: \"{Content}\"";
        }
    }
}
