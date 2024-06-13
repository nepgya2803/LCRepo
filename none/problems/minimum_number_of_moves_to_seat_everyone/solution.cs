public class Solution {
    public int MinMovesToSeat(int[] seats, int[] students) {
        Array.Sort(seats);
        Array.Sort(students);
        int move = 0;
        for(int i = 0; i < seats.Length; i++)
        {
            int step = Math.Abs(students[i] - seats[i]);
            move += step;
            
        }

        return move;
    }
}