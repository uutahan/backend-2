# Backend Study - Question 2
- We have StackNode generic class which holds data of type T. Also holds the position of our previous element of stack, that is the next element comes to the top of stack if we pop from stack.
- We also have ThreeStack generic class holds data type T. This data type can be string or int or some other type that we wanted. Our array's elements has this type T.
- Inside ThreeStack class we have stackTopPointers that holds position of the top of each stack, but first element it holds is exceptional. It holds top of the empty positions of our array.
- When we push an element of type T to some stack, we first get position of top of that stack. Then we get the next empty position from the first element of our stackTopPointers variable. Then we get element correspons to that position and change its data value to push's input data value and change its PrevNodeLocation value to old top of stack. Then we make stack's new top value position of last changed element.
- When we pop we first get position of top of that stack. We add this position to available free positions(empty it).  And we change stack's top pointer to previous of current top element. Lastly we return element that we wanted to remove.
- Peek operations is simple, we check our stack's top pointer and get corresponding StackNode element from our array and return it.
- I implemented this for 3 stacks and total array's capacity as 15 but these values can be changed easily just by changing the variable vales.
- Program uses space efficiently and if there is empty space it can be used by any stack.
