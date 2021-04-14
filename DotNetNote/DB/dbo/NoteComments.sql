﻿-- 댓글용 NoteComments DDL
Create Table dbo.NoteComments
(
    Id          Int Identity(1, 1) 
                Not Null Primary Key,               -- 일련번호
    BoardName   NVarChar(50) Null,                  -- 게시판이름(확장): Notice
    BoardId     Int Not Null,                       -- 해당 게시판의 게시물 번호
    Name        NVarChar(25) Not Null,              -- 작성자
    Opinion     NVarChar(4000) Not Null,            -- 댓글 내용
    PostDate    SmallDateTime Default(GetDate()),   -- 작성일
    Password    NVarChar(20) Not Null               -- 댓글 삭제용 암호
)
Go