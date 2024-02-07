# Bank
개인과제 - ATM 시스템 만들기  

# 개발기간  
2024.02.01 ~ 2024.02.07  

# 구현 내용  
--2024.02.03--  
UI 제작  
Background, Title, 입금 화면, 입금 버튼, 출금 화면, 출금 버튼  

오브젝트 제작  
GameManager 오브젝트  

Script 추가  
MoveBtn.cs - 입금 화면 이동, 출금 화면 이동, 뒤로가기 구현  
GameManager.cs - 싱글톤만 구현  

-- 2024.02.05--  
UI 제작  
Tribe  

Script 추가  
MoneyBtn - 삭제(수정부분에 내용 추가)  
GameManager - ExiBtn 기능 추가(잔액부족 팝업 끄기)  

UI 명칭 수정  
one,three,fiveBtn > TenThousandWon, ThirtyThousandWon, FiftyThousandWon  

Script 수정  
MoneyBtn 내용을 아래처럼 수정  
DepositMoneyBtn - Deposit의 만원,삼만원,오만원 버튼 관련 내용 추가  
WithdrawalMoneyBtn - Withdrawal의 만원,삼만원,오만원 버튼 관련 내용 추가  

# 버그
InputField로 출금을 하면 오류가 남 - FormatException: Input string was not in a correct format.  

# 해결
GameManager에서 InputWithdrawal 부분에서 input.text로 되어 있는 부분에 inputDeposit.text로 되어 있었음  
inputDeposit를 inputWithdrawal로 변경  


-- 2024.02.07--  
UI 수정 + 명칭은 거의 그대로 둠  

Script 전부 영상 강의와 비슷하게 변경  

전에 만든것 남겼어야 하는데 잘못해서 덮어쓰기 되어버림...  
