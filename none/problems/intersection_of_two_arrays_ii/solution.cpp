class Solution {
 public:
  std::vector<int> intersect(std::vector<int>& nums1, std::vector<int>& nums2) {
    std::vector<int> result;
    std::map<int, int> m;
    for (int i = 0; i < nums1.size(); i++) {
      if (m.find(nums1[i]) != m.end()) {
        m[nums1[i]]++;
      } else {
        m.insert({nums1[i], 1});
      }
    }

    for (int i = 0; i < nums2.size(); i++) {
      if (m.find(nums2[i]) != m.end() && m[nums2[i]] > 0) {
        m[nums2[i]]--;
        result.push_back(nums2[i]);
      }
    }

    return result;
  }
};