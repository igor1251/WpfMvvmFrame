   M S B A M L   `   `   `  ����G  CWpfMvvmFrame, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null]3clr-namespace:WpfMvvmFrame.DialogWindows.AddStudent%WpfMvvmFrame.DialogWindows.AddStudent  5   	   <    6WpfMvvmFrame.DialogWindows.AddStudent.AddStudentWindow   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   Elocal3clr-namespace:WpfMvvmFrame.DialogWindows.AddStudent     5   	   -   5          �Name$  addStudentWindow��5   	    � Title$ Add new student��5	   	    � SizeToContent$ Height=�5
   	   $	��400��5   	    � WindowStartupLocation$ CenterOwner=�5   	    � DataContext 5      ?   9WpfMvvmFrame.DialogWindows.AddStudent.AddStudentViewModel  5   
   .��5      �  � ColumnDefinitions 5   
   �� 5      $
��Auto �6   �� 5       � RowDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $��* �6   �� 5      $
��Auto �6   .+�5   
   �� $��Surname��6   $��0��6"   $��0��6/   $��Center=�6?   �� 5    
   $
��Name��6   $��1��6   $��0��6,   $��Center=�6<   �� 5!   
   $��Lastname��6   $��2��6#   $��0��60   $��Center=�6@   �� 5"   
   $��Date of birth��6   $��3��6(   $��0��65   $��Center=�6E   �� 5#   
   $	��Age��6   $��4��6   $��0��6+   $��Center=�6;   �� 5%   
   $��5 5 5 5q�6   $��0��6#   $��1��60   $��Center=�6@   ��6[   �� *Student.Surname+ �� Mode$ TwoWay=� �� UpdateSourceTrigger$ PropertyChanged=��� 5&   
   $��5 5 5 5q�6   $��1��6#   $��1��60   $��Center=�6@   ��6[   �� *Student.Name+$ TwoWay=�$ PropertyChanged=��� 5'   
   $��5 5 5 5q�6   $��2��6#   $��1��60   $��Center=�6@   ��6[   �� *Student.Lastname+$ TwoWay=�$ PropertyChanged=�(  "System.Windows.Controls.DatePicker  5(   
   $��5 5 5 5q�6   $��3��6&   $��1��63   $��Center=�6C   	   SelectedDate	 6^   �� *Student.DateOfBirth+�� 5)   
   $��5 5 5 5q�6   $��4��6#   $��1��60   $��Center=�6@   ��6[   �� *Student.Age+$ TwoWay=�$ PropertyChanged=��� 5+   
   $��2��6   $��6��6)   
 �� Orientation$
 
Horizontal=�66   $��Center=�6O   $��Right=�6j   .+�5,      �� $��Accept��6   $	��100��6&   $��5 5 5 5q�62   ��6C   �� *AcceptCommand+��6e   ��  �� ElementName$ addStudentWindow���� 5-      $��Decline��6   $	��100��6'   $��5 5 5 5q�63   ��6D   �� *DeclineCommand+��6g   �� $ addStudentWindow��5.      5/      50      