   M S B A M L   `   `   `  ����  Регистрация.    (Регистрация.AdminVerification   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	     � Title$  Admin Verification��5   	   $	��350��6$   $	��525��61   .��5      � .+�5   
   &   System.Windows.Controls.DataGrid  -   5          Name$ UsersDataGrid��5         AutoGenerateColumns .     
IsReadOnly .  $��10q�6Y      SelectionMode$ Extended=�6e      SelectionUnit$ FullRow=�6~      Columns 5      4  .System.Windows.Controls.DataGridCheckBoxColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ Select��6)   1  +System.Windows.Controls.DataGridBoundColumn   Binding 69   �� *
IsSelected+	 �� Mode$	 TwoWay=�0  *System.Windows.Controls.DataGridTextColumn  5	      $ ID��6%   
   
IsReadOnly
 .  61   �� *
id_users+6N     5
      $	 FIO��6%   
 .  62   �� *	fio_users+6P     5      $ Email��6%   
 .  64   �� *email_users+6T     5      $ Grups��6%   
 .  64   �� *grups_and_fio+6V     5      $ 	Otdelenie��6%   
 .  68   �� *	otdelenie+6V   5      �� 5   
   -   5         ��Name$ ApproveButton��5      $��Approve��6(   $
��Left=�6:   $��Bottom=�6U   $��75��6p   $��10q�6{   6�   5      5      