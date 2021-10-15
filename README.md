# Day7-Tanks
Тема: Обработка исключительных ситуаций. Перегрузка операторов.</br>
Задание 1. </br>
Цель: Разработать программу, моделирующую танковый бой.</br>
В танковом бою участвуют 5 танков «Т-34»
и 5 танков «Pantera». Каждый танк («Т-34» и «Pantera»)
описываются параметрами: «Боекомплект», «Уровень
брони», «Уровень маневренности». Значение данных
параметров задаются случайными числами от 0 до 100.
Каждый танк участвует в парной битве, т.е. первый
танк «Т-34» сражается с первым танком «Pantera» и т. д.
Победа присуждается тому танку, который превышает
противника по двум и более параметрам из трех.</br>
Основное требование: сражение (проверку на победу в бою)
реализовать путем перегрузки оператора "*" (произведение).</br>
1. В решение добавить новый проект с именем «Day7(Tanks)»,
в котором будут промоделированы танковые сражения. В данный
проект добавить ссылку на библиотеку классов «MyClassLib».
2. В библиотеке классов «MyClassLib» создать папку «WordOfTanks»,
а в ней разработать класс с именем «Tank». В классе должно быть реализовано:</br>
- поля: закрытые поля, предназначенные для представления
1. Названия танка.
2. Уровня боекомплекта танка.
3. Уровня брони.
4. Уровня маневренности.</br>
-конструктор:
Конструктор с параметрами, обеспечивающий инициализацию всех полей класса Tank.
При этом Боекомплект, Уровень брони, Уровень маневренности инициализируются случайными числами от 0 до 100 %.
Название танка передаются в конструктор из функции Main().
- перегрузка оператора «*»(произведение):
При перегрузке оператора «*» (произведение) должна быть реализована проверка
на победу в бою одного танка по отношению к другому.
Критерий победы – победивший танк должен превышать проигравший танк не менее чем по двум из трех параметров (Боекомплект, Уровень брони, Уровень маневренности).
- методы:
Получение текущих значений параметров танка: Боекомплект, Уровень брони, Уровень маневренности в виде строки.
