﻿// You are implementing a program to use as your calendar. We can add a new event if adding the event will not cause a double booking.

// A double booking happens when two events have some non-empty intersection (i.e., some moment is common to both events.).

// The event can be represented as a pair of integers start and end that represents a booking on the half-open interval [start, end), the range of real numbers x such that start <= x < end.

// Implement the MyCalendar class:

// MyCalendar() Initializes the calendar object.
// boolean book(int start, int end) Returns true if the event can be added to the calendar successfully without causing a double booking. Otherwise, return false and do not add the event to the calendar.
public class MyCalendar {
        Dictionary<int,int> dict;
    public MyCalendar() {
        dict = new();
    }
    
    public bool Book(int start, int end) {
        if(dict.ContainsKey(start)) return false;
        foreach(int key in dict.Keys){
            if(start>key && start<dict[key]) return false;
            if(end>key && end<dict[key]) return false;
            if(start<=key && end>=dict[key]) return false;
        }
        dict[start] = end;
        return true;
    }
}
