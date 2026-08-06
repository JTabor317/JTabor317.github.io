public void TryStep(Vector2 inputDir)
{
    if (isMoving || mytilemap == null)
        return;

    // Snap to cardinal direction.
    Vector2Int dir = ToCardinal(inputDir);
    if (dir == Vector2Int.zero)
        return;

    // Current cell.
    Vector3Int currentCell = mytilemap.WorldToCell(transform.position);
    Vector3Int nextCell = currentCell + new Vector3Int(dir.x, dir.y, 0);

    // Wall check.
    if (IsBlocked(nextCell))
        return;

    // Check for pushable.
    Pushable blockInFront = FindPushableInCell(nextCell);

    if (blockInFront != null)
    {
        Clickable cl = blockInFront.GetComponent<Clickable>();

        if ((cl == null) || (!cl.IsMinimized()))
        {
            Vector2Int nextBlockScalers = new Vector2Int(1, 1);

            if (cl != null)
            {
                ButtonEffectTile p = FindEffectTileInCell(nextCell);
                if (p != null)
                    cl.setOnEffectTile(p.getActiveType(), false);

                nextBlockScalers = new Vector2Int(
                    (int)cl.getCurrentScalers().x,
                    (int)cl.getCurrentScalers().y
                );
            }

            Vector3Int blockMoveTargetCall =
                new Vector3Int(
                    (int)math.floor(blockInFront.transform.position.x),
                    (int)math.floor(blockInFront.transform.position.y),
                    0
                ) + new Vector3Int(dir.x, dir.y, 0);

            Vector3Int blockWallTargetCell =
                nextCell + new Vector3Int(dir.x * nextBlockScalers.x, dir.y * nextBlockScalers.y, 0);

            if (IsBlocked(blockWallTargetCell) || FindPushableInCell(blockWallTargetCell) != null)
                return;

            Vector3 blockTargetPos = mytilemap.GetCellCenterWorld(blockMoveTargetCall);
            StartCoroutine(MoveObject(blockInFront.transform, blockTargetPos, false));

            if (cl != null)
            {
                ButtonEffectTile p = FindEffectTileInCell(blockMoveTargetCall);
                if (p != null)
                    cl.setOnEffectTile(p.getActiveType(), true);
            }
        }
    }
}
