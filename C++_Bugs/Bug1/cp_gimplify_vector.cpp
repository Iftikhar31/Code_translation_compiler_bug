//The following program generates an ICE on trunk, but compiles on 14.2:
#include <vector>
int main() {
   for (auto i : (true ? std::vector<int>{1, 2} : std::vector<int>{2, 1})) {
   }
}
