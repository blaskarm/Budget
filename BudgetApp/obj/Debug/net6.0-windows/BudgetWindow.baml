   M S B A M L   `   `   `  ����D  @BudgetApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:BudgetApp	BudgetApp  5   	       BudgetApp.BudgetWindow   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   )localclr-namespace:BudgetApp     5   	     � Title$  BudgetWindow��5   	   $	��500��6   $	��700��6+    � 
ResizeMode$ CanMinimize=�5	   	   $��Arial)�6"    � WindowStartupLocation$ CenterScreen=�65   .��5      �  � ColumnDefinitions 5   
   �� 5      $	��125 �6   �� 5      $��* �6    � RowDefinitions 5   
   �� 5      $��70 �6   �� 5      $��* �6   .+�5   
   �� $��images/BudgetLogo.jpg��6   �� 5   
   -   5         ��Name$ mainTextBlock��5      $
��Home��6+   $��1��67   $
��Left=�6G   $��Center=�6b   $��24(�6}   $��SemiBold"�6�   ���#2a2a2a$��30 0 0 0q�5   )   �� 5    
   $��Current Budget:��6   $��1��6+   ���#2a2a2a$��10(�6P   $��Center=�6^   $��0 10 0 0q�6{   �� 5!   
   -   5        $ currentBudgetText��5!      $��1��6/   ���#404040$��10(�5"      $��
10 0 10 10q�6"    �� Padding$ 2q�66   $��Center=�6B   $��Center=�6_   �� 5%   
   -   5        $ userNameTextBlock��5%      $��1��6R   $��Right=�6b   $��Center=�6~   $��20(�6�   $��SemiBold"�6�   ���#2a2a2a$��0 0 30 0q�5&   )   ��5%   /   �� *Name+ �� Mode$ OneWay=�5&   )   �� 5(   
   $��1��6   $��Bottom=�6$   
���   � J� Opacity$	 0.5Q�6R   $
��10 0q�6`    � 5+   
   -   5        	  �Name$	 	homeFrame��5+      $��1��6#   $��1��60   
  � NavigationUIVisibility$
 Hidden=�6@    � 5,   
   -   5        $	 createBudgetFrame��5,      $��1��6+   $��1��68   $
 Hidden=�6H    � 5-   
   -   5        $	 addSavingsFrame��5-      $��1��6)   $��1��66   $
 Hidden=�6F    � 5.   
   -   5        $	 myBudgetsFrame��5.      $��1��6(   $��1��65   $
 Hidden=�6E    � 5/   
   -   5        $	 settingsFrame��5/      $��1��6'   $��1��64   $
 Hidden=�6D    � 50   
   -	   5        $	 editBudgetFrame��50      $��1��6)   $��1��66   $
 Hidden=�6F   � 54   
   $��1��6    56      �� 57      $��* �6    �� 58      $��50 �6    .+�5<      �� .+�5>      �� -
   5         ��Name$ 
homeButton��5>         RoundedButtonStyle#���   6-   $
��Home��5?      $��11(�6(   $��6q�66   $��
10 20 10 7q�6B   ���#0080ff
�������$��Arial)�5C       � Cursor$
 Hand��5D      �� 5F      -   5        $ createBudgetButton��5F      #���   65   $��Create Budget��5G      $��11(�61   $��6q�6?   $��	10 0 10 7q�6K   ���#0080ff
�������$��Arial)�5K      $
 Hand��5L      �� 5N      -   5        $ addSavingsButton��5N      #���   63   $��Add Savings��5O      $��11(�6/   $��6q�6=   $��	10 0 10 7q�6I   ���#0080ff
�������$��Arial)�5S      $
 Hand��5T      �� 5V      -   5        $ myBudgetsButton��5V      #���   62   $��
My Budgets��5W      $��11(�6.   $��6q�6<   $
��10 0q�6H   ���#0080ff
�������$��Arial)�5[      $
 Hand��5\      �� 5^      -   5        $ settingsButton��5^      #���   61   $��Settings��5_      $��11(�6,   $��6q�6:   $
��10 7q�6F   ���#0080ff
�������$��Arial)�5c      $
 Hand��5d      5f      �� 5h      -   5        $ logoutButton��5h      #���   6+   $��1��6X   $��Logout��5j      $��11(�6&   $��6q�64   $��10q�6@   ���#0080ff
�������$��Arial)�5m      $
 Hand��5n      5o      5r      5u      