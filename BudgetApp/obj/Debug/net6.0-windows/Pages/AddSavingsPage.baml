   M S B A M L   `   `   `  ����D  @BudgetApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:BudgetApp.PagesBudgetApp.Pages  5      $    BudgetApp.Pages.AddSavingsPage   5      W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      /localclr-namespace:BudgetApp.Pages     5        N� 
FontFamily$  Arial)�5   0    N� Title$ AddSavingsPage��5	      .��5      �  � ColumnDefinitions 5   
   �� 5      $��* �6   �� 5      $
��1.6* �6   �� 5      $��* �6   .+�5   
   �� $��1��6   .+�5      �� $��
Add Saving��6   ���#2a2a2a$��16(�6?    �� Padding$ 2q�6M   $��	0 20 0 20q�6Y   $��Center=�5      �� 5      $��Amount��6   ���#404040$��12(�6;   $ 2q�6I   $��	20 0 10 5q�6U   �� 5      -   5         ��Name$ addSavingAmountTextbox��5      $��
20 0 20 10q�5      $��1q�6*   �� 5      -   5         ��Name$ addSavingButton��5      $	��Add��6.   $
��50 5q�6<      RoundedButtonStyle#��[  6J   $��2q�5      ���#0080ff
������� � Cursor$
 Hand��5       �� 5#      $��Subtract Saving��6   ���#2a2a2a$��16(�6D   $ 2q�6R   $��	0 40 0 10q�6^   $��Center=�5$      �� 5&      $��Amount��6   ���#404040$��12(�6;   $ 2q�6I   $��	20 0 10 5q�6U   �� 5'      -   5        $ removeSavingAmountTextbox��5'      $��
20 0 20 10q�5(      $��1q�6*   �� 5*      -   5        $ subtractSavingButton��5*      $��Subtract��63   $
��50 5q�6F   #��[  6T   $��2q�5,      ���#0080ff
�������$
 Hand��5.      50      53      56      