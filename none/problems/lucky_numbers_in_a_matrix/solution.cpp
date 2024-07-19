class Solution
{
    public:
        std::vector<int> luckyNumbers(std::vector<std::vector<int>>& matrix)
        {
            int sizeRow = matrix.size() - 1;
            int sizeCol = matrix[0].size() - 1;
            std::cout << sizeRow << sizeCol << std::endl;
            std::vector<int> maxRow;

            for (int i = 0; i <= sizeRow; i++)
            {
                auto row =
                  *std::min_element(matrix[i].begin(), matrix[i].end());
                maxRow.push_back(row);
            }

            std::vector<int> maxCol;
            for (int i = 0; i <= sizeCol; i++)
            {
                int max = matrix[0][i];
                for (int y = 0; y <= sizeRow; y++)
                {
                    max = std::max(max, matrix[y][i]);
                }
                maxCol.push_back(max);
            }

            std::vector<int> result;
            std::sort(maxRow.begin(), maxRow.end());
            std::sort(maxCol.begin(), maxCol.end());
            std::set_intersection(maxRow.begin(), maxRow.end(), maxCol.begin(),
                                  maxCol.end(),
                                  std::inserter(result, result.begin()));

            return result;
        }
};