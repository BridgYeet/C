   M S B A M L   `   `   `  ����R  NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R8clr-namespace:System.ComponentModel;assembly=WindowsBaseSystem.ComponentModel  5   	   B >WpfApp5, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:SOYSOY 5   	      SOY.MainWindow   5   	   W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      5   	   R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml      5   	   @d2http://schemas.microsoft.com/expression/blend/2008      5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006      5   	   Hscm8clr-namespace:System.ComponentModel;assembly=WindowsBase      5   	   #localclr-namespace:SOY      5   	   -   5          � Title$	  SOY��5	   	   $	��600��6   $
��1000��6"   .��5
      �  � ColumnDefinitions 5   
   �� 5      $
��753* �6   �� 5      $
��247* �6   .+�5   
   &   System.Windows.Controls.DataGrid  -   5          Name$ SOYlist��5      $��263,84,0,61q�6$   
���   �   AutoGenerateColumns$ False��6M   $��2��6i      Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      -   5        Column_1��,  &System.Windows.Controls.DataGridColumn   
IsReadOnly$ False��5   T      Header$ ФИО��6g      Width5  /System.Windows.Controls.DataGridLengthConverter$ * 6t      CanUserSort$
 True��6~   1  +System.Windows.Controls.DataGridBoundColumn	   Binding	 67   �� 
 �� Path$	
 FIO�6~     5      -   5        Column_2��$ False��5   U   $ Полных лет��6h   $ * 6|   $
 True��6�   	 67   �� $

 Goda�6�     5      -   5        Column_4��$ False��5   [   $  Специальность��6n   $ * 6�   $
 True��6�   	 67   �� $
 
Speciality�6�     5      -   5        Column_5��$ False��5   V   $! Номер телефона��6i   $ * 6�   $
 True��6�   	 67   �� $
 Phone�6�     5      -   5        Column_3��$ False��5   V   $ 
Оклад��6i   $
 0.5* 6x   $
 True��6�   	 67   �� $
 Oklad�6�   5      �� 5   
   -   5         ��Name$ ListBoxLists��5   S   $��6,106,495,61q�6=   6i   �� 5   
   -	   5        $��Создать отдел��5      $
��Left=�6)   $��	10,27,0,0q�6D   $	��Top=�6W   $��30��6o   $	��117��6{   6�   �� 5   
   -
   5         ��Name$ TextBoxNamelist��5      $
��Left=�6+   $��7,78,0,0q�6F    �� TextWrapping$
 Wrap=�6X   $�� ��6l   $	��Top=�6u   $	��251��6�   $��28��6�   �� 5   
   $
��Left=�6   $��	10,58,0,0q�6/   $
��Wrap=�6B   $	��Top=�6V   $	��150��6n   $��24��6z   �� 6�   $�Введите имя ��6�   �� 6�    � Language$ ru-ru�6�   $�отдела��6�   �� 6�   $�:��6�   6�   �� 5   
   -   5         ��Name$ DeleteButton��5   3   $��29��6   $��132,27,509,0q�6   $	��Top=�6I   $��Удалить отдел��6|   �� 5   
   -   5        $
��Left=�5      $��
263,53,0,0q�6-   $
 Wrap=�6A   $�� ��6U   $	��Top=�6]   $	��150��6u   $��26��6�   6�   �� 5   
   $
��Left=�6   $��
263,35,0,0q�6/   $
��Wrap=�6C   $	��Top=�6W   $��23��6o   $	��118��6{   �� 6�   $�Поиск по��6�   �� 6�   $ ru-ru�6�   $�:��6�   6�   �� 5   
   -   5         ��Name$ Combo��5      $
��Left=�6"   $��
322,32,0,0q�6=   $	��Top=�6Q   $	��120��6i   .@�5       �� ФИО6   �� 5!      Возрасту6"   �� 5"      Специальности6'   �� 5#      Телефону6"   5$      5'      5(      