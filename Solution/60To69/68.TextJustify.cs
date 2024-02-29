using System.Text;

public class FullJustify_Solution {
    public IList<string> FullJustify(string[] words, int maxWidth) {
        // Solution 1
        // var result = new List<string>();
        // var i = 0;
        // while (i < words.Length){
        //     var j = i + 1;
        //     var lineLength = words[i].Length;
        //     while (j < words.Length && lineLength + words[j].Length + j - i <= maxWidth){
        //         lineLength += words[j].Length;
        //         j++;
        //     }
        //     var spaces = maxWidth - lineLength;
        //     var spacesBetweenWords = j - i - 1;
        //     var line = new StringBuilder(words[i]);
        //     if (j == words.Length || spacesBetweenWords == 0){
        //         for (var k = i + 1; k < j; k++){
        //             line.Append(" " + words[k]);
        //         }
        //         for (var k = line.Length; k < maxWidth; k++){
        //             line.Append(" ");
        //         }
        //     }
        //     else{
        //         var spacesPerWord = spaces / spacesBetweenWords;
        //         var extraSpaces = spaces % spacesBetweenWords;
        //         for (var k = i + 1; k < j; k++){
        //             for (var l = 0; l < spacesPerWord; l++){
        //                 line.Append(" ");
        //             }
        //             if (extraSpaces > 0){
        //                 line.Append(" ");
        //                 extraSpaces--;
        //             }
        //             line.Append(words[k]);
        //         }
        //     }
        //     result.Add(line.ToString());
        //     i = j;
        // }
        // return result;


        // Solution 2
        var result = new List<string>();
        for (var i = 0 ; i < words.Length; i++){
            var line = new List<string>();
            var lineLength = 0;
            while (i < words.Length && lineLength + words[i].Length + line.Count <= maxWidth){
                lineLength += words[i].Length;
                line.Add(words[i]);
                i++;
            }
            i--;
            var spaces = maxWidth - lineLength;
            var spacesBetweenWords = line.Count - 1;
            var lineStr = string.Empty;
            if (i == words.Length - 1 || spacesBetweenWords == 0){
                lineStr = string.Join(" ", line);
                lineStr += new string(' ', maxWidth - lineStr.Length);
            }
            else{
                var spacesPerWord = spaces / spacesBetweenWords;
                var extraSpaces = spaces % spacesBetweenWords;
                for (var j = 0; j < line.Count; j++){
                    lineStr += line[j];
                    if (j < line.Count - 1){
                        lineStr += new string(' ', spacesPerWord);
                        if (extraSpaces > 0){
                            lineStr += " ";
                            extraSpaces--;
                        }
                    }
                }
            }
            result.Add(lineStr);
        }
        return result;
    }
}