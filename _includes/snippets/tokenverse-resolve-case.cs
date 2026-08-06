private void MoveDraggedObject()
{
    Ray ray = GetMouseRay();
    if (!dragPlane.Raycast(ray, out float enter))
    {
        return;
    }

    Vector3 target = ray.GetPoint(enter) + dragOffset;
    draggedObject.transform.position = Vector3.Lerp(
        draggedObject.transform.position,
        target,
        Time.deltaTime * dragMoveSpeed
    );
}

private PlacementPoint FindNearestPlacementPoint(EvidenceObject evidence)
{
    if (ShouldPrioritizeCustomerSpot(evidence))
    {
        PlacementPoint customerPoint =
            FindNearestCustomerPointInPriorityRange(evidence);

        if (customerPoint != null)
        {
            return customerPoint;
        }
    }

    PlacementPoint nearest = null;
    float nearestDistance = float.PositiveInfinity;

    foreach (PlacementPoint point in PlacementPoint.AllPoints)
    {
        if (!point.CanPlace(evidence))
        {
            continue;
        }

        Vector3 placementPosition =
            point.GetClosestPlacementPosition(evidence.transform.position);

        float distance = Vector3.SqrMagnitude(
            placementPosition - evidence.transform.position
        );

        if (distance < nearestDistance)
        {
            nearestDistance = distance;
            nearest = point;
        }
    }

    return nearest;
}

private PlacementPoint FindNearestCustomerPointInPriorityRange(
    EvidenceObject evidence)
{
    PlacementPoint nearest = null;
    float nearestDistance =
        customerSpotPriorityRadius * customerSpotPriorityRadius;

    foreach (PlacementPoint point in PlacementPoint.AllPoints)
    {
        if (!point.IsCustomerSpot || !point.CanPlace(evidence))
        {
            continue;
        }

        Vector3 placementPosition =
            point.GetClosestPlacementPosition(evidence.transform.position);

        float distance = Vector3.SqrMagnitude(
            placementPosition - evidence.transform.position
        );

        if (distance <= nearestDistance)
        {
            nearestDistance = distance;
            nearest = point;
        }
    }

    return nearest;
}