class Solution:
    def evalRPN(self, tokens: List[str]) -> int:
        stack = []

        for token in tokens:
            if token == '+':
                first = stack.pop()
                second = stack.pop()
                stack.append(first + second)
            elif token == '-':
                first = stack.pop()
                second = stack.pop()
                stack.append(second - first)  # order matters
            elif token == '/':
                first = stack.pop()
                second = stack.pop()
                stack.append(int(second / first))  # truncates toward zero
            elif token == '*':
                first = stack.pop()
                second = stack.pop()
                stack.append(first * second)
            else:
                stack.append(int(token))

        return stack.pop()
