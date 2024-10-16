# 파일 분리 ?
어떻게 하지...
- text (가장 먼저 로드할 놈)
    - json (text-json)
        - battle
            - boss
            - entity
            - other
        - event
- sprite
    - ui
        - base
            1. background
            2. window
            3. 
        - battle
            - cards
        - field
        - event
    - bg (sprite-bg)
        1. Title
        1. Map
        2. Field[1~10]
    - entity
        - boss
            - 보드 녀석들
        - enemy
            - 기본적인 적들
        - other
            1. shop
            2. treasure
- audio
    - bgm
        - title (audio-bgm-title)
            - index
        - battle (audio-bgm-battle)
            - Stage[1~3]
            - Boss[1~3]
            - Warning
            - Gameover
        - field (audio-bgm-field)
            - Stage[1~3]
    - se (audio-se)
        1. attack
        2. damage
        3. defence
    - other (audio-other)
        - 위의 분류 쳬게로 분류하기 힘든 놈들
- prefab
    - card
        - hero1
    - entity
        - boss
        - enemy
        - other