/*
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