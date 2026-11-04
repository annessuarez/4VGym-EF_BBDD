GO
SET IDENTITY_INSERT [Activities] ON;
INSERT INTO [Activities] ([Id], [ActivityTypeId], [MaxParticipants], [DateStart], [DateEnd])
VALUES
    (1, 1, 25, '2026-11-10 10:00:00', '2026-11-10 11:00:00'),
    (2, 2, 20, '2026-11-10 11:30:00', '2026-11-10 12:30:00'),
    (3, 3, 15, '2026-11-11 09:00:00', '2026-11-11 10:00:00'),
    (4, 4, 30, '2026-11-12 18:00:00', '2026-11-12 19:30:00');
SET IDENTITY_INSERT [Activities] OFF;
GO

INSERT INTO [ActivityInstructor] ([ActivitysId], [InstructorsId])
VALUES
    (1, 1), -- Actividad 1 (BodyPump) impartida por Miguel
    (1, 2), -- Actividad 1 (BodyPump) co-impartida por María
    (2, 2), -- Actividad 2 (Spinning) impartida por María
    (3, 3), -- Actividad 3 (Pilates) impartida por Iban
    (4, 1), -- Actividad 4 (CrossFit) impartida por Miguel
    (4, 3); -- Actividad 4 (CrossFit) impartida por Iban
GO
