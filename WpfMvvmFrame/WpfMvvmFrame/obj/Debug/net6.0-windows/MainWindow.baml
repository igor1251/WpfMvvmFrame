   M S B A M L   `   `   `  ����G  CWpfMvvmFrame, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:WpfMvvmFrameWpfMvvmFrame  5   	   A%clr-namespace:WpfMvvmFrame.ViewModelsWpfMvvmFrame.ViewModels  5   	       WpfMvvmFrame.MainWindow   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ,localclr-namespace:WpfMvvmFrame     5   	   <
viewmodels%clr-namespace:WpfMvvmFrame.ViewModels     5   	     � Title$   CommunityToolkit.Mvvm Demo��5	   	   $	��600��5
   	   $	��500��5   	    � WindowStartupLocation$ CenterScreen=�5   	    � DataContext 5      1   +WpfMvvmFrame.ViewModels.MainWindowViewModel  5   
   .��5      �  � RowDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $��* �6   �� 5      $
��Auto �6   .+�5   
   o� .@�5      m� $
��File��6   .@�5      m� $��Choose db file...��6   5      m� 5      $��Close��6   m� 5      $��About��6   5      &   System.Windows.Controls.DataGrid  5   
   $��1��6      AutoGenerateColumns$ False��6       CanUserAddRows$ False��6<   ��6S   �� *AvailableStudents+   Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ Surname��6%      Width5  /System.Windows.Controls.DataGridLengthConverter$ * 66   1  +System.Windows.Controls.DataGridBoundColumn	   Binding	 6@   �� *	Surname+  5       $
 Name��6%   $ * 63   	 6=   �� *Name+  5!      $ Lastname��6%   $ * 67   	 6A   �� *
Lastname+  5"      $ Date of birth��6%   $ * 6<   	 6F   �� *DateOfBirth+
 �� StringFormat$
 
dd/MM/yyyy��  5#      $	 Age��6%   $
 Auto 62   	 6?   �� *Age+5%      �� 5&   
   $��2��6    �� Orientation$ 
Horizontal=�6"   $��Center=�6;   $
��Left=�6V   .+�5'      �� $	��Add��6   $	��100��6#   $��5 5 5 5q�6/   ��6@   �� *AddStudentCommand+5(      5)      5*      