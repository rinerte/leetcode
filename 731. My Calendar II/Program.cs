// You are implementing a program to use as your calendar. We can add a new event if adding the event will not cause a triple booking.

// A triple booking happens when three events have some non-empty intersection (i.e., some moment is common to all the three events.).

// The event can be represented as a pair of integers start and end that represents a booking on the half-open interval [start, end), the range of real numbers x such that start <= x < end.

// Implement the MyCalendarTwo class:

// MyCalendarTwo() Initializes the calendar object.
// boolean book(int start, int end) Returns true if the event can be added to the calendar successfully without causing a triple booking. Otherwise, return false and do not add the event to the calendar.
public class MyCalendarTwo {
    private SortedDictionary<int, int> bookingCount;
    private const int maxOverlappedBooking = 2;

    public MyCalendarTwo() {
        bookingCount = new SortedDictionary<int, int>();
    }
    
    public bool Book(int start, int end) {
        if (!bookingCount.ContainsKey(start))
        {
            bookingCount[start] = 0;
        }
        bookingCount[start]++;

        if (!bookingCount.ContainsKey(end))
        {
            bookingCount[end] = 0;
        }
        bookingCount[end]--;

        int overlappedBooking = 0;

        // Calculate the prefix sum of bookings
        foreach (var entry in bookingCount)
        {
            overlappedBooking += entry.Value;

            // If the number of overlaps exceeds the allowed limit, rollback and return false
            if (overlappedBooking > maxOverlappedBooking)
            {
                // Rollback changes
                bookingCount[start]--;
                bookingCount[end]++;

                // Clean up if the count becomes zero to maintain the map clean
                if (bookingCount[start] == 0)
                {
                    bookingCount.Remove(start);
                }

                if (bookingCount[end] == 0)
                {
                    bookingCount.Remove(end);
                }

                return false;
            }
        }

        return true; 
    }
}
