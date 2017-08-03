/*
A linked list is said to contain a cycle if any node is visited more than once while traversing the list.

Complete the function provided in the editor below. It has one parameter: a pointer to a Node object named that points to the head of a linked list. Your function must return a boolean denoting whether or not there is a cycle in the list. If there is a cycle, return true; otherwise, return false.

Note: If the list is empty,  will be null.

Input Format

Our hidden code checker passes the appropriate argument to your function. You are not responsible for reading any input from stdin.

Constraints

Output Format

If the list contains a cycle, your function must return true. If the list does not contain a cycle, it must return false. The binary integer corresponding to the boolean value returned by your function is printed to stdout by our hidden code checker.

Sample Input

The following linked lists are passed as arguments to your function:

1-> null
1-> 2 -> 3
    ^    |
    |____|
    
Sample Output

0
1 

Explanation

The first list has no cycle, so we return false and the hidden code checker prints  to stdout.
The second list has a cycle, so we return true and the hidden code checker prints  to stdout.

Detect a cycle in a linked list. Note that the head pointer may be 'null' if the list is empty.

A Node is defined as: 
    class Node {
        int data;
        Node next;
    }
*/

boolean hasCycle(Node head) {

        int count = 0;
    
        Node bunny, turtle;
        
        turtle = head;
        bunny = head;
        
    
        if(head == null){
            return false;
        }    
        while(true){
            count++;
            
            turtle = turtle.next;
            
            if(bunny.next != null){
                bunny = bunny.next.next;
            }
            else{
                return false;
            }
            
            if(turtle == null || bunny == null){
                return false;
            }
            if(turtle == bunny){
                return true;
            }
            if(count > 100){
                return false;
            }
        }
}
