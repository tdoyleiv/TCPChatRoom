# TCPChatRoom
S- SetChatRoom method is an example of the solid principle. This is because all it does is set the current message to the current chat room and that is it. Nothing else. This follows accordingly to its single responsibility very well.
O-CheckMessage method is an example of the open principle.This is because if you wanted to impliment more things in the form, the CheckMessage method allows you to add more (if else) cases accordingly. It is open to extensionin the sense that all of the other (if else) cases work perfectly fine even after (if else) cases are added, but closed to modification because it is a private message method. 
