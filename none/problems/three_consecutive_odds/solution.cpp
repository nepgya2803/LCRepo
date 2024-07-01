class Solution {
public:
  bool threeConsecutiveOdds(std::vector<int> &arr) {
    int size = arr.size();
    for (int i = 0; i <= (size - 3); i++) {
      if (arr[i] % 2 + arr[i + 1] % 2 + arr[i + 2] % 2 == 3) {
        return true;
      }
    }

    return false;
  }
};